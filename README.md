Start API
API cadastro de produto, utilizando .Net Framework 4.8, Injeção de dependência e Swagger para facilitar o consumo da APi.
O banco de dados está no formato MDF na pasta App_Data.
Validação usada de forma simplista com data annotation.
Manipulação de dados no banco através de procedures.
EndPoints com função de inserção, atualização, exclusão, busca geral, busca por identificador e atualização parcial.


# Desafio .NET
Desafio de contratação Khipo. Realize um fork deste repositório e faça as etapas referentes a sua vaga. O intuito desse teste é ser algo simples, porém suficiente para validar a qualidade do seu código.

# Desafio 1

## Etapa 1 

Utilizando o .Net Framework (https://docs.microsoft.com/pt-br/dotnet/framework/get-started/overview) crie uma ``API Rest``. Essa API deverá ser capaz de CRUD em um banco de dados de ``Produtos``. Utilizar procedure para os GETs com o banco de dados.

``GET /api/v1/products``
Retorna todos os produtos em lista

``GET /api/v1/products/:productId``
Retorna apenas o produto do productId

Exemplo de produtos:
```
[
 {
  "createdAt": "2022-05-20T00:31:08.822Z",
  "name": "Incredible Plastic Pants",
  "price": "827.00",
  "brand": "Hauck - Johnson",
  "updatedAt": "2022-05-22T02:31:08.822Z",
  "id": "1"
 },
 {
  "createdAt": "2022-05-20T09:05:23.745Z",
  "name": "Electronic Wooden Tuna",
  "price": "765.00",
  "brand": "Johns - Farrell",
  "updatedAt": "2022-05-20T09:05:23.745Z",
  "id": "2"
 },
 {
  "createdAt": "2022-05-20T02:07:28.065Z",
  "name": "Awesome Steel Mouse",
  "price": "143.00",
  "brand": "Paucek, Kuvalis and Zieme",
  "updatedAt": "2022-05-23T22:35:23.745Z",
  "id": "3"
 },
 ]
```

Observações
1. É necessario utilizar ADO.Net (https://docs.microsoft.com/pt-br/dotnet/framework/data/adonet/)
2. É essencial que seja conectado em um banco de dados SQL Server.

## Etapa 2

Conectar a API com um Gateway em VB.NET

# Desafio 2

## Etapa 1

Utilizando o .Net Core (https://docs.microsoft.com/pt-br/dotnet/core/introduction) crie uma ``API Rest``. Essa API deverá ser capaz de CRUD em um banco de dados de ``Produtos``. Utilizar procedure para os GETs com o banco de dados.

``GET /api/v1/products``
Retorna todos os produtos em lista

``GET /api/v1/products/:productId``
Retorna apenas o produto do productId

Observações
1. É essencial que seja conectado em um banco de dados SQL Server.
2. Não permita dois ou mais produtos com o mesmo Id, ele deve ser incremental

## Etapa 2 (Opcional)

Criar uma exibição em VB 6 com os dados provindos da API em um formulário (table).
