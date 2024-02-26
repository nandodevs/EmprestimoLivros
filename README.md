## Empréstimo de Livros com ASP.NET Core MVC e Docker

**Descrição:**

Este projeto demonstra a criação de um sistema de empréstimo de livros utilizando ASP.NET Core MVC, Entity Framework Core e Docker. O sistema permite aos usuários:

* **Gerenciar livros:** adicionar, editar e remover livros da biblioteca.
* **Gerenciar autores:** adicionar, editar e remover autores da biblioteca.
* **Gerenciar usuários:** adicionar, editar e remover usuários do sistema.
* **Realizar empréstimos:** registrar empréstimos e devoluções de livros.
* **Consultar histórico:** visualizar o histórico de empréstimos e devoluções.

**Tecnologias utilizadas:**

* **ASP.NET Core MVC:** framework web para desenvolvimento de aplicações web modernas e escaláveis.
* **Entity Framework Core:** ORM (Object-Relational Mapping) que facilita o mapeamento entre objetos e entidades no banco de dados.
* **Docker:** plataforma para criação, envio e execução de aplicações em containers.
* **SQL Server:** banco de dados relacional para armazenar os dados do sistema.

**Bibliotecas:**

* **Microsoft.EntityFrameworkCore:** biblioteca principal do Entity Framework Core.
* **Microsoft.EntityFrameworkCore.SqlServer:** provedor de EF Core para SQL Server.
* **Microsoft.Extensions.Configuration:** biblioteca para gerenciar configurações da aplicação.
* **Microsoft.Extensions.DependencyInjection:** biblioteca para injeção de dependências.
* **Docker.NET:** biblioteca para trabalhar com Docker a partir de aplicações .NET.

**Estrutura do projeto:**

O projeto é dividido em três pastas principais:

* **API:** contém a API RESTful do sistema, desenvolvida com ASP.NET Core MVC.
* **Data:** contém as classes de modelo e o contexto do Entity Framework Core.
* **Docker:** contém os arquivos de configuração do Docker para a aplicação.

**Como executar o projeto:**

1. Clone o repositório para o seu computador.
2. Restaure as dependências do projeto com o comando `dotnet restore`.
3. Crie o banco de dados SQL Server e configure a string de conexão no arquivo `appsettings.json`.
4. Crie a imagem Docker com o comando `docker build -t emprestimo-livros .`.
5. Execute a aplicação com o comando `docker run -p 8080:80 emprestimo-livros`.
6. Acesse a aplicação no navegador em `http://localhost:8080`.

**Observações:**

* Este projeto é apenas um exemplo demonstrativo e pode ser adaptado de acordo com suas necessidades.
* Para mais informações sobre ASP.NET Core MVC, Entity Framework Core e Docker, consulte a documentação oficial das tecnologias.

**Tags:**

* #aspnetcore
* #dotnet
* #mvc
* #entityframeworkcore
* #sqlserver
* #docker
* #emprestimo
* #livros

**Links úteis:**

* Documentação do ASP.NET Core MVC: [https://learn.microsoft.com/pt-br/aspnet/core/?view=aspnetcore-8.0](https://learn.microsoft.com/pt-br/aspnet/core/?view=aspnetcore-8.0)
* Documentação do Entity Framework Core: [https://docs.abp.io/pt-BR/abp/latest/Entity-Framework-Core](https://docs.abp.io/pt-BR/abp/latest/Entity-Framework-Core)
* Documentação do Docker: [https://docs.docker.com/get-started/](https://docs.docker.com/get-started/)

**Contribuições:**

Sinta-se à vontade para contribuir com o projeto, reportando bugs ou sugerindo melhorias.
