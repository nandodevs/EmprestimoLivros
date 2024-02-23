<<<<<<< HEAD
﻿using EmprestimoLivros.Models;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoLivros.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //Classe que cria as tabelas do banco de dados
        public DbSet<EmprestimosModel> Emprestimos { get; set; }

    }
}
=======
﻿using EmprestimoLivros.Models;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoLivros.Data
{
    public class ApplicationDbContext : DbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)

        {

        }

        //Classe que cria as tabelas do banco de dados
        public DbSet<EmprestimosModel> Emprestimos { get; set; }

    }
}
>>>>>>> 82f58fd (Branch tester created)
