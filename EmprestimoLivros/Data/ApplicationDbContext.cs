
using DoramasControl.Models;
using Microsoft.EntityFrameworkCore;

namespace DoramasControl.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //Classe que cria as tabelas do banco de dados
        public DbSet<DoramasModel> Doramas { get; set; }

    }
}
