using Microsoft.EntityFrameworkCore;
using TheBestStore.Models;

namespace TheBestStore.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
