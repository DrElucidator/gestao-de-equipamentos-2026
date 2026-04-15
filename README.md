# Gestão de Equipamentos

Junior cuida do estoque de equipamentos na empresa onde trabalha. E sempre controla o inventário dos seus equipamentos, os fabricantes associados e as manutenções que eles já sofreram em uma planilha.

Desta forma, ele resolveu pedir ajuda do pessoal da Academia do Programador no desenvolvimento de um Software para automatizar o seu serviço.

## 1. Controle de Equipamentos

#### Requisito 1.1:

Como funcionário, Junior quer ter a possibilidade de registrar equipamentos

- Deve ter identificador único (id)
- Deve ter um nome com no mínimo 6 caracteres;
- Deve ter um preço de aquisição;
- Deve ter uma fabricante;
- Deve ter uma data de fabricação;

#### Requisito 1.2:

Como funcionário, Junior quer ter a possibilidade de visualizar todos os equipamentos registrados em seu inventário.

- Deve mostrar o id;
- Deve mostrar o nome;
- Deve mostrar o preço de aquisição;
- Deve mostrar a fabricante;
- Deve mostrar a data de fabricação;

#### Requisito 1.3:

Como funcionário, Junior quer ter a possibilidade de editar um equipamento, sendo que ele possa editar todos os campos.

- Deve ter os mesmos critérios que o Requisito 1.1.

#### Requisito 1.4:

Como funcionário, Junior quer ter a possibilidade de excluir um equipamento que esteja registrado.

- A lista de equipamentos deve ser atualizada

## 2. Controle de Fabricantes

#### Requisito 2.1:

Como funcionário, Junior quer ter a possibilidade de registrar fabricantes

- Deve ter identificador único (id)
- Deve ter um nome com no mínimo 2 caracteres;
- Deve ter um e-mail;
- Deve ter um telefone;

#### Requisito 2.2:

Como funcionário, Junior quer ter a possibilidade de visualizar todos os fabricantes registrados.

- Deve mostrar o id;
- Deve mostrar o nome;
- Deve mostrar o e-mail;
- Deve mostrar o telefone;
- Deve mostrar a quantidade de produtos (equipamentos) associados;

#### Requisito 2.3:

Como funcionário, Junior quer ter a possibilidade de editar um fabricante, sendo que ele possa editar todos os campos.

- Deve ter os mesmos critérios que o Requisito 2.1.

#### Requisito 2.4:

Como funcionário, Junior quer ter a possibilidade de excluir um fabricante que esteja registrado.

- A lista de fabricantes deve ser atualizada

## 3. Controle de Chamados

#### Requisito 3.1:

Como funcionário, Junior quer ter a possibilidade de registrar chamados de manutenção

- Deve ter identificador único (id)
- Deve ter um título com no mínimo 3 caracteres;
- Deve ter uma descrição;
- Deve ter uma data de abertura;
- Deve estar associado a um equipamento;

#### Requisito 3.2:

Como funcionário, Junior quer ter a possibilidade de visualizar todos os chamados registrados.

- Deve mostrar o id;
- Deve mostrar o título;
- Deve mostrar a descrição;
- Deve mostrar a data de abertura;
- Deve mostrar o equipamento associado;
- Deve mostrar os dias decorridos desde a abertura;

#### Requisito 3.3:

Como funcionário, Junior quer ter a possibilidade de editar um chamado, sendo que ele possa editar todos os campos.

- Deve ter os mesmos critérios que o Requisito 3.1.

#### Requisito 3.4:

Como funcionário, Junior quer ter a possibilidade de excluir um chamado que esteja registrado.

- A lista de chamados deve ser atualizada

## Como utilizar

1. Clone o repositório ou baixe o código fonte.
2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as dependências do projeto.

   ```bash
   dotnet restore
   ```

4. Para executar o projeto compilando em tempo real

   ```bash
   dotnet run --project GestaoDeEquipamentos.ConsoleApp
   ```

## Requisitos

- .NET 10.0 SDK
