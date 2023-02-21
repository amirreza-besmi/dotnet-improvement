using dotnet_improvement.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace dotnet_improvement.Infrastructure.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=UsersDb;Integrated Security=True");
        }
    }
}
