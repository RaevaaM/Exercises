using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace BorsaUsers.Data
{
    public class BorsaDbContext : IdentityDbContext<Customer>
    {
        public BorsaDbContext(DbContextOptions<BorsaDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<TypesProduct> TypesProducts { get; set; }
             
    }
}