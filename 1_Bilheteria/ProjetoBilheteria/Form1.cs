using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoBilheteria
{
    public partial class Form1 : Form
    {
        private Label lblTexto;
        private ComboBox comboBoxMenu;

        private Label lblFileira;
        private Label lblColuna;
        private TextBox txtFileira;
        private TextBox txtColuna;
        private Button btnReservar;

        private Panel panelOperacoes;

        private const int fileiras = 15;
        private const int qtdPoltronas = 40;
        private double valorFileira_1a5 = 50.00;
        private double valorFileira_6a10 = 30.00;
        private double valorFileira_11a15 = 15.00;

        private bool[,] poltronas = new bool[fileiras, qtdPoltronas];
        private string arquivoEstado = "estadoPoltronas.txt";

        public Form1()
        {
            InitializeComponent();
            InitializeMyComponents();
            CarregarReservas();
        }

        private void InitializeMyComponents()
        {
            lblTexto = new Label
            {
                Text = "Bem-vindo ao Cinema. Selecione uma operação que deseja realizar:",
                Location = new Point(10, 10),
                Size = new Size(500, 20)
            };

            comboBoxMenu = new ComboBox
            {
                Location = new Point(10, 40),
                Size = new Size(150, 20)
            };
            comboBoxMenu.Items.AddRange(new object[]
            {
                "0 - Finalizar",
                "1 - Reservar poltrona",
                "2 - Mapa de Ocupação",
                "3 - Faturamento"
            });
            comboBoxMenu.SelectedIndexChanged += ComboBoxMenu_SelectedIndexChanged;

            panelOperacoes = new Panel
            {
                Location = new Point(10, 80),
                Size = new Size(300, 400)
            };

            this.Controls.Add(lblTexto);
            this.Controls.Add(comboBoxMenu);
            this.Controls.Add(panelOperacoes);
        }

        private void ComboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpa o painel de operações para evitar sobreposição de controles
            panelOperacoes.Controls.Clear();

            switch (comboBoxMenu.SelectedItem.ToString())
            {
                case "0 - Finalizar":
                    MessageBox.Show("Aplicação encerrada.");
                    this.Close();
                    break;

                case "1 - Reservar poltrona":
                    ReservarPoltrona();
                    break;

                case "2 - Mapa de Ocupação":
                    ExibirMapaOcupacao();
                    break;

                case "3 - Faturamento":
                    ExibirFaturamento();
                    break;

                default:
                    MessageBox.Show("Seleção inválida. Escolha uma operação válida.");
                    break;
            }
        }

        private void ReservarPoltrona()
        {
            // Inicializando os componentes de entrada
            lblFileira = new Label
            {
                Text = "Fileira (1-15):",
                Location = new Point(10, 80),
                Size = new Size(100, 20)
            };
            txtFileira = new TextBox
            {
                Location = new Point(120, 80),
                Size = new Size(50, 20)
            };
            lblColuna = new Label
            {
                Text = "Coluna (1-40):",
                Location = new Point(10, 110),
                Size = new Size(100, 20)
            };
            txtColuna = new TextBox
            {
                Location = new Point(120, 110),
                Size = new Size(50, 20)
            };
            btnReservar = new Button
            {
                Text = "Reservar",
                Location = new Point(10, 140),
                Size = new Size(75, 30)
            };
            btnReservar.Click += BtnReservar_Click;

            panelOperacoes.Controls.Add(lblFileira);
            panelOperacoes.Controls.Add(txtFileira);
            panelOperacoes.Controls.Add(lblColuna);
            panelOperacoes.Controls.Add(txtColuna);
            panelOperacoes.Controls.Add(btnReservar);
        }

        private void BtnReservar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtFileira.Text, out int fileira) && int.TryParse(txtColuna.Text, out int coluna))
            {
                int indiceFileira = fileira - 1;
                int indiceColuna = coluna - 1;

                if (indiceFileira >= 0 && indiceFileira < fileiras && indiceColuna >= 0 && indiceColuna < qtdPoltronas)
                {
                    if (!poltronas[indiceFileira, indiceColuna])
                    {
                        poltronas[indiceFileira, indiceColuna] = true;
                        MessageBox.Show("Poltrona reservada com sucesso!");

                        // Limpar os campos de texto
                        txtFileira.Clear();
                        txtColuna.Clear();

                        // Salvar a poltrona reservada no arquivo
                        SalvarReserva(fileira, coluna);
                    }
                    else
                    {
                        MessageBox.Show("Poltrona já ocupada.");
                    }
                }
                else
                {
                    MessageBox.Show("Coordenadas inválidas. Insira fileira de 1 a 15 e coluna de 1 a 40.");
                }
            }
            else
            {
                MessageBox.Show("Entrada inválida. Insira números válidos.");
            }
        }

        private void ExibirMapaOcupacao()
        {
            string mapaOcupacao = "";
            int totalPoltronas = fileiras * qtdPoltronas;
            int poltronasOcupadas = 0;

            for (int i = 0; i < fileiras; i++)
            {
                for (int j = 0; j < qtdPoltronas; j++)
                {
                    mapaOcupacao += poltronas[i, j] ? "# " : ". ";
                    if (poltronas[i, j]) poltronasOcupadas++;
                }
                mapaOcupacao += Environment.NewLine;
            }

            double porcentagemOcupacao = (double)poltronasOcupadas / totalPoltronas * 100;
            mapaOcupacao += $"Porcentagem de ocupação: {porcentagemOcupacao:F2}%";

            MessageBox.Show(mapaOcupacao, "Mapa de Ocupação");
        }

        private void ExibirFaturamento()
        {
            int totalOcupados = 0;
            double totalFaturamento = 0;

            for (int i = 0; i < fileiras; i++)
            {
                for (int j = 0; j < qtdPoltronas; j++)
                {
                    if (poltronas[i, j])
                    {
                        totalOcupados++;
                        if (i < 5) totalFaturamento += valorFileira_1a5;
                        else if (i < 10) totalFaturamento += valorFileira_6a10;
                        else totalFaturamento += valorFileira_11a15;
                    }
                }
            }

            MessageBox.Show($"Qtde de lugares ocupados: {totalOcupados}\nValor da bilheteira: R$ {totalFaturamento:F2}", "Faturamento");
        }

        private void SalvarReserva(int fileira, int coluna)
        {
            using (StreamWriter sw = new StreamWriter(arquivoEstado, true))
            {
                sw.WriteLine($"Fileira: {fileira}, Coluna: {coluna}");
            }
        }

        private void CarregarReservas()
        {
            if (File.Exists(arquivoEstado))
            {
                using (StreamReader sr = new StreamReader(arquivoEstado))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        string[] partes = linha.Split(new[] { ' ', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                        if (partes.Length == 4)
                        {
                            if (int.TryParse(partes[1], out int fileira) && int.TryParse(partes[3], out int coluna))
                            {
                                if (fileira >= 1 && fileira <= fileiras && coluna >= 1 && coluna <= qtdPoltronas)
                                {
                                    poltronas[fileira - 1, coluna - 1] = true;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
