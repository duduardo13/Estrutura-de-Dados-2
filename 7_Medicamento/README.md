## Autor
**Eduardo Barbosa Rodrigues**  
**RA**: CB302637X


# Sistema de Gestão de Medicamentos

## Descrição do Projeto
O Sistema de Gestão de Medicamentos é uma aplicação desenvolvida em C# para gerenciar medicamentos, seus lotes, e realizar operações como compra, venda, cadastro e consulta. O objetivo é permitir um controle eficiente do estoque de medicamentos, registrando cada lote e mantendo informações atualizadas sobre as quantidades disponíveis.

## Funcionalidades
O programa oferece as seguintes funcionalidades:
1. **Cadastrar Medicamento**: Adicionar um novo medicamento com suas informações básicas.
2. **Consultar Medicamento (Sintético)**: Exibir os dados básicos do medicamento, incluindo ID, nome, laboratório e quantidade disponível.
3. **Consultar Medicamento (Analítico)**: Exibir os dados básicos do medicamento e os detalhes de seus lotes.
4. **Comprar Medicamento**: Cadastrar um novo lote para um medicamento existente.
5. **Vender Medicamento**: Abater a quantidade vendida dos lotes mais antigos.
6. **Listar Medicamentos**: Mostrar a lista de todos os medicamentos cadastrados com suas informações básicas.
7. **Excluir Medicamento**: Remover medicamentos que não possuem quantidade disponível (realizado automaticamente).

## Estrutura do Projeto
O projeto é dividido em três classes principais e um programa principal:

### Classes
1. **Lote**
   - Representa um lote de medicamentos com ID, quantidade e data de vencimento.
   - Métodos principais:
     - Construtores.
     - `ToString()`: Exibe os dados do lote no formato `ID-Quantidade-Vencimento`.

2. **Medicamento**
   - Representa um medicamento com ID, nome, laboratório e uma fila de lotes.
   - Métodos principais:
     - `QtdeDisponivel()`: Retorna a quantidade total disponível somando todos os lotes.
     - `Comprar(Lote)`: Adiciona um novo lote à fila.
     - `Vender(int)`: Realiza a venda e abate as quantidades dos lotes mais antigos.
     - `ToString()`: Exibe os dados básicos do medicamento no formato `ID-Nome-Laboratório-QuantidadeDisponível`.
     - `ConsultarAnalitico()`: Exibe os dados detalhados do medicamento e seus lotes.

3. **Medicamentos**
   - Gerencia a lista de medicamentos cadastrados.
   - Métodos principais:
     - `Adicionar(Medicamento)`: Adiciona um medicamento à lista.
     - `Deletar(Medicamento)`: Remove um medicamento da lista se não houver quantidade disponível.
     - `Pesquisar(int)`: Busca um medicamento pelo ID.
     - `Listar()`: Retorna todos os medicamentos cadastrados.

### Programa Principal
- Exibe um menu interativo com as opções descritas na seção **Funcionalidades**.
- Permite que o usuário realize operações diretamente pelo console.


