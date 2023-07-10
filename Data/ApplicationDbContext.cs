using Microsoft.EntityFrameworkCore;
using loader_thales.Models;

namespace loader_thales.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }

        public DbSet<EmprestimosModel> Emprestimos {get; set;}
        
    }
}