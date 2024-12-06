using Microsoft.EntityFrameworkCore;
using Aqsha.Models;

namespace Aqsha.Data
{
    public class AqshaDbContext : DbContext
    {
        public AqshaDbContext(DbContextOptions<AqshaDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Credit> Credits { get; set; }
    }
}
