# Projeto Transporte

**Aluno:** Eduardo Barbosa Rodrigues - CB302637X

## Descrição

Uma empresa de fretamento possui hoje uma frota de 8 vans (numeradas de 1 a 8) e realiza uma rota regular entre os aeroportos de Congonhas e Guarulhos (ida e volta), com uma garagem em cada destino.

### Cenário Atual
- Frota composta por 8 vans.
- Rota regular entre Congonhas e Guarulhos.
- Estacionamento em garagens com acesso único, onde os veículos são posicionados de forma que o último a entrar seja o primeiro a sair (Pilha).

### Funcionamento
1. **Viagens**: Quando a lotação de uma van está completa, ela sai em direção ao destino e é estacionada na garagem de chegada.
2. **Controle de Viagens**: Uma nova viagem só pode ser iniciada de uma origem quando um veículo retorna à garagem.
3. **Início da Jornada**: Os veículos são distribuídos alternadamente entre as garagens.
4. **Encerramento da Jornada**: Uma lista com a quantidade de passageiros transportados por veículo é gerada e os dados anteriores são resetados.
5. **Cadastro**: Novos veículos e garagens só podem ser adicionados com a jornada diária encerrada.

## Requisitos

### Objetivos

A aplicação deve:
- **Criar um diagrama de classes** que atenda ao domínio do problema.
- **Implementar funcionalidades** para controlar o fluxo da frota com base no cenário descrito.

### Funcionalidades do Menu

0. **Finalizar**: Encerra a aplicação.
1. **Cadastrar Veículo**: Permite o cadastro de novos veículos na frota (apenas com jornada encerrada).
2. **Cadastrar Garagem**: Adiciona novas garagens (apenas com jornada encerrada).
3. **Iniciar Jornada**: Distribui os veículos alternadamente entre as garagens e inicia a jornada.
4. **Encerrar Jornada**: Gera o relatório de passageiros transportados e limpa os registros de viagens.
5. **Liberar Viagem**: Inicia uma viagem de uma origem para um destino especificado.
6. **Listar Veículos em Garagem**: Mostra os veículos disponíveis em uma garagem, informando o potencial de transporte.
7. **Quantidade de Viagens**: Informa o número de viagens realizadas entre uma origem e um destino.
8. **Listar Viagens Efetuadas**: Exibe os detalhes das viagens entre uma origem e um destino.
9. **Quantidade de Passageiros**: Mostra a quantidade total de passageiros transportados entre uma origem e um destino.


#
## DIAGRAMA

|-------------------------------|
|           Veiculo             |
|-------------------------------|
| - id: int                     |
| - capacidade: int             |
| - passageiros: int            |
|-------------------------------|
| + getId(): int                |
| + getCapacidade(): int        |
| + getPassageiros(): int       |
| + adicionarPassageiro(): void |
| + limparPassageiros(): void   |
|-------------------------------|



|--------------------------------------------|
|                  Garagem                   |
|--------------------------------------------|
| - id: int                                  |
| - local: String                            |
| - veiculos: List<Veiculo>                  |
|--------------------------------------------|
| + getId(): int                             |
| + getLocal(): String                       |
| + adicionarVeiculo(veiculo: Veiculo): void |
| + removerVeiculo(veiculo: Veiculo): void   |
| + listarVeiculos(): List<Veiculo>          |
|--------------------------------------------|



|------------------------------|
|           Viagem             |
|------------------------------|
| - origem: Garagem            |
| - destino: Garagem           |
| - passageiros: int           |
| - veiculo: Veiculo           |
|------------------------------|
| + getOrigem(): Garagem       |
| + getDestino(): Garagem      |
| + getPassageiros(): int      |
| + getVeiculo(): Veiculo      |
|------------------------------|




|----------------------------------------------------------------------------|
|                              ControleFrota                                 |
|----------------------------------------------------------------------------|
| - garagens: List<Garagem>                                                  |
| - veiculos: List<Veiculo>                                                  |
| - viagens: List<Viagem>                                                    |
|----------------------------------------------------------------------------|
| + cadastrarVeiculo(veiculo: Veiculo): void                                 |
| + cadastrarGaragem(garagem: Garagem): void                                 |
| + iniciarJornada(): void                                                   |
| + encerrarJornada(): void                                                  |
| + liberarViagem(origem: Garagem, destino: Garagem, veiculo: Veiculo): void |
| + listarVeiculos(garagem: Garagem): List<Veiculo>                          |
| + qtdViagens(origem: Garagem, destino: Garagem): int                       |
| + listarViagens(origem: Garagem, destino: Garagem): List<Viagem>           |
| + qtdPassageirosTransportados(origem: Garagem, destino: Garagem): int      |
|----------------------------------------------------------------------------|