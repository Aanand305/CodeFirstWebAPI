using Microsoft.EntityFrameworkCore;

namespace CodeFirstWebAPI.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Products> Products { get; set; }
    }
}
