using EmprestimoLivros.Models;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoLivros.Data
{
    public class ApplicationDbContext : DbContext
    {
<<<<<<< HEAD
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
=======
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
>>>>>>> 25b43c8a1cdcea57305af8b31dc0c8156aebed46
        {

        }

        //Classe que cria as tabelas do banco de dados
        public DbSet<EmprestimosModel> Emprestimos { get; set; }

    }
}
