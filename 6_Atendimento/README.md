# Projeto Atendimento

**Aluno** Eduardo Barbosa Rodrigues  CB302637X

## Estrutura do Projeto: 

|Senha| 
|-|
|- id: int|
|- dataGerac: DateTime|
|- horaGerac: DateTime|
|- dataAtend: DateTime|
|- horaAtend: DateTime|
||
|+ Senha (ind id) => instanciar o objeto inicializando atributos id, DataGerac, HoraGerac|
|+ gerar() : string => retornar id + ”-“ + DataGerac + ”-“ + HoraGerac + ”-“ + DataAtend + ”-“ + HoraAtend |

|Senhas| 
|-|
|- proximoAtendimento: int|
|- filaSenhas: Queue<Senha>|
||
|+ Senhas() => instanciar a fila de senhas e definir o próximo atendimento como 1|
|+  gerar(): void => colocar a senha gerada na fila de senhas|

|Guiche|
|-|
|- id: int|
|- atendimetos: Queue<Senha>|
|+ Guiche() => instanciar a fila de atendimentos e Inicializar id com 0|
|+ Guiche(int id) => instanciar a fila de atendimentos e Inicializar id com o argumento passado|
|+ chamar(Queue<Senha> filaSenhas): bool => retirar a próxima senha da fila de senhas e coloca-la na fila de atendimentos do respectivo guichê. Retornar indicativo de sucesso (true/false)|

|Guiches|
|-|
|- listaGuiches: List<Guiche>|
||
|+ Guiche() => instanciar a lista de guichês|
|+ adicionar(Guiche guiche) => adicionar um novo guichê à lista de guichês|