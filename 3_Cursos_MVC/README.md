**Aluna:** Laysa Bernardes Campos da Rocha  
**Matrícula:** CB3024873 

# Sistema de Gestão Escolar
Este projeto é um sistema de gestão escolar que permite gerenciar cursos, disciplinas e alunos. A aplicação permite que os alunos se inscrevam em disciplinas, respeitando as regras de matrícula e limites estabelecidos.

# Programa Funcionando:

![Gif do projeto](./Cursos.gif)

## Funcionalidades

- **Cursos**: O sistema permite adicionar até 5 cursos de tecnologia, cada um contendo até 12 disciplinas.
- **Disciplinas**: Cada disciplina pode ter no máximo 15 alunos matriculados.
- **Matrícula de Alunos**: Cada aluno pode estar matriculado em apenas um curso e, no máximo, 6 disciplinas simultaneamente.
- **Pesquisa**: É possível pesquisar cursos, disciplinas e alunos, exibindo informações relevantes.

## Diagrama de Classes

### Aluno
```plaintext
----------------------------------------
Aluno
----------------------------------------
id: int
nome: string
----------------------------------------
+ podeMatricular(Cursos cursos): bool
----------------------------------------
```

### Disciplina
```plaintext
----------------------------------------
Disciplina
----------------------------------------
- id: int
- descricao: string
- alunos: Aluno[15]
----------------------------------------
+ matricularAluno(Aluno aluno): bool
+ desmatricularAluno(Aluno aluno): bool
----------------------------------------
```

### Curso
```plaintext
----------------------------------------------------------
Curso
----------------------------------------------------------
id: int
descricao: string
disciplinas: Disciplina[12]
----------------------------------------------------------
+ adicionarDisciplina(Disciplina disciplina): bool
+ pesquisarDisciplina(Disciplina disciplina): Disciplina
+ removerDisciplina(Disciplina disciplina): bool
----------------------------------------------------------
```

### Escola
```plaintext
------------------------------------
Escola
------------------------------------
cursos: Curso[5]
------------------------------------
+ adicionarCurso(Curso curso): bool
+ pesquisarCurso(Curso curso): Curso
+ removerCurso(Curso curso): bool
------------------------------------
```

## Opções do Menu

O sistema apresenta um menu interativo com as seguintes opções:

0. Sair  
1. Adicionar curso  
2. Pesquisar curso (mostrar inclusive as disciplinas associadas)  
3. Remover curso (não pode ter nenhuma disciplina associada)  
4. Adicionar disciplina no curso  
5. Pesquisar disciplina (mostrar inclusive os alunos matriculados)  
6. Remover disciplina do curso (não pode ter nenhum aluno matriculado)  
7. Matricular aluno na disciplina  
8. Remover aluno da disciplina  
9. Pesquisar aluno (informar seu nome e em quais disciplinas ele está matriculado)  

