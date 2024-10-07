**Aluna:** Laysa Bernardes Campos da Rocha  
**Matrícula:** CB3024873 

# Projeto Contato

UTILIZE O DIAGRAMA DE CLASSES APRESENTADO À SEGUIR PARA DESENVOLVER UMA APLICAÇÃO COM AS OPÇÕES ABAIXO:

----------------------------------------------
| Data                                       |
|--------------------------------------------|
| - dia: int                                 |
| - mes: int                                 |
| - ano: int                                 |
|--------------------------------------------|
| + setData(int dia, int mes, int ano): void |
| + ToString(): String (override)            |
|   -> retornando "dd/mm/aaaa"               |
----------------------------------------------

----------------------------------------------
| Telefone                                   |
|--------------------------------------------|
| - tipo: string                             |
| - numero: string                           |
| - principal: bool                          |
----------------------------------------------

-----------------------------------------
| Contato                               |
|---------------------------------------|
| - email: string                       |
| - nome: string                        |
| - dtNasc: Data                        |
| - telefones: List<Telefone>           |
|---------------------------------------|
| + getIdate(): int                     |
| + adicionarTelefone(Telefone t): void |
| + getTelefonePrincipal(): string      |
| + ToString(): String (override)       |
|   -> retornando uma string com        |
|      todos os dados do contato        |
|      (considerando o telefone         |
|      principal)                       |
| + Equals(object obj): bool (override) |
-----------------------------------------
 

-----------------------------------------
| Contatos                              |
|---------------------------------------|
| - agenda: List<Contato> (readOnly)    |
|---------------------------------------|
| + adicionar(Contato c): bool          |
| + pesquisar(Contato c): Contato       |
| + alterar(Contato c): bool            |
| + remover(Contato c): bool            |
-----------------------------------------
 
Implementar construtores, getter's e setter's (ou as respectivas Propriedades).
OBSERVAÇÕES:

O PROJETO PODERÁ SER DESENVOLVIDO EM C# CONSOLE APPLICATION ou WINDOWS FORMS APPLICATION.
EM QUALQUER DAS OPÇÕES, DEVERÁ OFERECER AS SEGUINTES OPÇÕES PARA O USUÁRIO 
(ADAPTANDO LOGICAMENTE PARA A INTERFACE ESCOLHIDA)


 0. Sair                           
 1. Adicionar contato               
 2. Pesquisar contato               
 3. Alterar contato                 
 4. Remover contato               
 5. Listar contatos                 



