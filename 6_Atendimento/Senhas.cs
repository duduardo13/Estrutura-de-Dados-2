using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Atendimento
{
    internal class Senhas
    {
        private int proximoAtendimento;
        private Queue<Senha> filaSenhas;

        public Senhas()
        {
            this.filaSenhas = new Queue<Senha>();
            proximoAtendimento = 1;
        }

        public Queue<Senha> getFilaSenhas()
        {
            return this.filaSenhas;
        }

        public void gerar()
        {
            Senha novaSenha = new Senha(proximoAtendimento);

            this.filaSenhas.Enqueue(novaSenha);

            this.proximoAtendimento++;
        }
    }
}
