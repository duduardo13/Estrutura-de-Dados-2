**Aluna:** Laysa Bernardes Campos da Rocha  
**Matrícula:** CB3024873 

# Sistema de Gerenciamento de Vendedores

## Descrição do Projeto

Este projeto implementa um sistema para gerenciar uma equipe de vendedores em uma empresa. A aplicação permite registrar e consultar informações sobre os vendedores e suas vendas, limitando o cadastro a um máximo de 10 vendedores.

# Programa Funcionando:

![Gif do projeto](./Vendedores.gif)

## Diagrama de Classes

### Classe Venda

| Atributos        | Tipo     |
|------------------|----------|
| `qtde`           | `int`    |
| `valor`          | `double` |

| Métodos                  | Retorno   |
|--------------------------|-----------|
| `valorMedio()`          | `double`  |

### Classe Vendedor

| Atributos            | Tipo             |
|----------------------|------------------|
| `id`                 | `int`            |
| `nome`               | `string`         |
| `percComissao`       | `double`         |
| `asVendas`           | `Venda[31]`      |

| Métodos                                  | Retorno   |
|------------------------------------------|-----------|
| `registrarVenda(int dia, Venda venda)`  | `void`    |
| `valorVendas()`                          | `double`  |
| `valorComissao()`                        | `double`  |

### Classe Vendedores

| Atributos               | Tipo             |
|-------------------------|------------------|
| `osVendedores`          | `Vendedor[]`     |
| `max`                   | `int`            |
| `qtde`                  | `int`            |

| Métodos                                      | Retorno   |
|----------------------------------------------|-----------|
| `addVendedor(Vendedor v)`                   | `bool`    |
| `delVendedor(Vendedor v)`                   | `bool`    |
| `searchVendedor(Vendedor v)`                | `Vendedor`|
| `valorVendas()`                              | `double`  |
| `valorComissao()`                            | `double`  |

## Funcionalidades

O sistema oferece as seguintes opções:

0. Sair
1. Cadastrar vendedor (*)
2. Consultar vendedor (**)
3. Excluir vendedor   (***)
4. Registrar venda
5. Listar vendedores  (****)

### Detalhes das Funcionalidades

- **(*) Cadastrar Vendedor**: Limita o cadastramento a um máximo de 10 vendedores.
  
- **(**) Consultar Vendedor**: Ao encontrar um vendedor, informa:
  - ID
  - Nome
  - Valor total das vendas
  - Valor da comissão devida
  - Valor médio das vendas diárias (considerando os dias com registro de vendas)

- **(***) Excluir Vendedor**: Um vendedor só pode ser excluído se não houver vendas registradas associadas a ele.

- **(****) Listar Vendedores**: Informa, para cada vendedor, os seguintes dados:
  - ID
  - Nome
  - Valor total das vendas
  - Valor da comissão devida
  Ao final, exibe a totalização dos valores.


