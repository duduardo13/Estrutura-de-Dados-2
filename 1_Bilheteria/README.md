**Aluna:** Laysa Bernardes Campos da Rocha  
**Matrícula:** CB3024873 

# ProjetoBilheteria

Este projeto implementa um sistema de controle de ocupação para um teatro com 600 lugares, dispostos em 15 fileiras com 40 poltronas cada. O sistema permite reservar poltronas, visualizar um mapa de ocupação e calcular o faturamento total com base nas reservas realizadas.

## Funcionalidades

1. **Reservar Poltrona**:
   - O sistema solicita a fileira e o número da poltrona.
   - Verifica se o lugar está vago e, em caso afirmativo, realiza a reserva e informa o usuário.
   - Caso o lugar já esteja ocupado, uma mensagem de alerta é exibida.
   - As reservas são salvas em um arquivo de texto (`estadoPoltronas.txt`) para persistência dos dados.

2. **Mapa de Ocupação**:
   - Exibe na tela um mapa com a ocupação do teatro, onde:
     - `.` representa lugar vago.
     - `#` representa lugar ocupado.

3. **Faturamento**:
   - Apresenta a quantidade de lugares ocupados e o valor total da bilheteria, com preços diferenciados por fileira:
     - Fileiras 1 a 5: R$ 50,00
     - Fileiras 6 a 10: R$ 30,00
     - Fileiras 11 a 15: R$ 15,00

4. **Salvar Reservas**:
   - Todas as reservas realizadas são salvas em um arquivo de texto (`estadoPoltronas.txt`), permitindo que o sistema recupere as ocupações salvas ao ser reaberto.

# Programa Funcionando:

![Gif do projeto](./bilheteria.gif)
