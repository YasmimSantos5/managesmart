using ManageSmart.Models;
using Microsoft.EntityFrameworkCore;

namespace ManageSmart.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
          : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; } //"Crie e gerencie uma tabela chamada Usuarios baseada na classe Usuario."
    }                                                // Cada DbSet representa uma tabela.
}
 
