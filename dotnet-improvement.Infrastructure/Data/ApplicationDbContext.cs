using dotnet_improvement.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace dotnet_improvement.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=ProductsDb;Integrated Security=True");
        }
    }
}
