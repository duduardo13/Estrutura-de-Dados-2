# Projeto Medicamento

**Aluno:** Eduardo Barbosa Rodrigues - CB302637X 

# README do Projeto Acesso

## Descrição

O **Projeto Acesso** simula um sistema de controle de acessos a ambientes em uma empresa, permitindo o gerenciamento de permissões de usuários e o registro de logs de ações (acessos e tentativas de acesso). Cada ambiente possui um dispositivo responsável por verificar se o usuário tem permissão para acessar, registrando todos os eventos em logs, que têm um limite de 100 registros por dispositivo, descartando as ocorrências mais antigas.

## Modelos

O sistema é estruturado em torno dos seguintes modelos:

### 1. **Usuário**
- **Atributos**:
  - `id` (int): Identificador único do usuário.
  - `nome` (string): Nome do usuário.
  - `ambientes` (List<Ambiente>): Lista de ambientes aos quais o usuário tem acesso.

- **Métodos**:
  - `concederPermissao(Ambiente ambiente)`: Concede permissão de acesso a um ambiente para o usuário. Retorna `true` se a permissão for concedida, ou `false` se já existir uma permissão para aquele ambiente.
  - `revogarPermissao(Ambiente ambiente)`: Revoga a permissão de acesso a um ambiente para o usuário. Retorna `true` se a permissão for revogada, ou `false` caso o usuário não tenha permissão.

### 2. **Ambiente**
- **Atributos**:
  - `id` (int): Identificador único do ambiente.
  - `nome` (string): Nome do ambiente.
  - `logs` (Queue<Log>): Fila que contém os logs de acesso do ambiente. O limite de registros é 100, descartando os mais antigos quando o limite é atingido.

- **Métodos**:
  - `registrarLog(Log log)`: Registra um log de acesso, garantindo que o número de registros não ultrapasse 100.

### 3. **Log**
- **Atributos**:
  - `dtAcesso` (DateTime): Data e hora do acesso.
  - `usuario` (Usuario): Usuário que realizou a ação.
  - `tipoAcesso` (bool): Indica se o acesso foi autorizado (`true`) ou negado (`false`).

### 4. **Cadastro**
- **Atributos**:
  - `usuarios` (List<Usuario>): Lista de usuários cadastrados no sistema.
  - `ambientes` (List<Ambiente>): Lista de ambientes cadastrados no sistema.

- **Métodos**:
  - `adicionarUsuario(Usuario usuario)`: Adiciona um novo usuário ao sistema.
  - `removerUsuario(Usuario usuario)`: Remove um usuário do sistema, retornando `true` se a remoção for bem-sucedida, ou `false` se o usuário ainda tiver permissões.
  - `pesquisarUsuario(Usuario usuario)`: Retorna um usuário específico, caso ele exista.
  - `adicionarAmbiente(Ambiente ambiente)`: Adiciona um novo ambiente ao sistema.
  - `removerAmbiente(Ambiente ambiente)`: Remove um ambiente do sistema, retornando `true` se a remoção for bem-sucedida, ou `false` se o ambiente tiver logs registrados.
  - `pesquisarAmbiente(Ambiente ambiente)`: Retorna um ambiente específico, caso ele exista.
  - `upload()`: Realiza a persistência dos dados ao finalizar a aplicação.
  - `download()`: Carrega os dados salvos ao iniciar a aplicação.

## Funcionalidades

O sistema possui um menu de opções, onde o usuário pode escolher as ações a serem realizadas. As opções incluem:

1. **Cadastrar ambiente**: Registra um novo ambiente no sistema.
2. **Consultar ambiente**: Exibe as informações de um ambiente existente.
3. **Excluir ambiente**: Remove um ambiente do sistema.
4. **Cadastrar usuário**: Registra um novo usuário no sistema.
5. **Consultar usuário**: Exibe as informações de um usuário existente.
6. **Excluir usuário**: Remove um usuário do sistema.
7. **Conceder permissão de acesso**: Vincula um usuário a um ambiente, concedendo-lhe permissão de acesso.
8. **Revogar permissão de acesso**: Desvincula um usuário de um ambiente, revogando sua permissão de acesso.
9. **Registrar acesso**: Registra um log de acesso de um usuário a um ambiente, indicando se o acesso foi autorizado ou negado.
10. **Consultar logs de acesso**: Exibe os logs de acesso de um ambiente, com a opção de filtrar por acessos autorizados, negados ou todos.

### Observações

- O sistema deve garantir que a persistência dos dados seja realizada ao encerrar a aplicação (usando o método `upload()`), e que os dados sejam carregados ao iniciar a aplicação (usando o método `download()`).
- As remoções de usuários e ambientes devem ser feitas com cuidado, garantindo que os usuários não sejam removidos enquanto ainda tiverem permissões de acesso, e que ambientes não sejam removidos enquanto houver registros de logs.
