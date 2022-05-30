# Desafio CSharp Rest
## O que foi usado para construir este projecto?
1. SQL Server 2019
2. .NET 6 LTS
3. Frameworks .NET
  1. Entity Framework Core (Para gestão do banco de dados)
  2. Quickwire (Para gestão de dependencias)
  3. Newtonsoft (Para serialização de instancias)
## Instruções

1. Antes de abrir o projecto na tua IDE favorita coloque as credenciais na variaveis de ambiente do teu computador.

2. Agora antes de mais nada crie a base de dados (SGBD SQLServer) com os valores que estão abaixo:
```
User id : sa;
Password: SQLServer;
Database: DesafioCSharpRest
```
3. Apos isso, no deirectório da aplicação execute o seguinte comando:
  ```
    dotnet ef database update
  ```
*Este comando vai criar as tabelas*

