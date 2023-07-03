using Microsoft.EntityFrameworkCore;
using ProductSystem.Models;

namespace ProductSystem.Data
{
    public class RepositoryContext:DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options):base(options)
        {
            
        }
        DbSet<Product> Products { get; set; }
    }
}
