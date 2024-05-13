using Microsoft.EntityFrameworkCore;
using MVC_pronia.Models;

namespace MVC_pronia.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }
        public DbSet<Category>Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
