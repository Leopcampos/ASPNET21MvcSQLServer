using Microsoft.EntityFrameworkCore;
using SalesWebMvcMySQL.Models;

namespace SalesWebMvcMySQL.Data
{
    public class SalesWebMvcMySQLContext : DbContext
    {
        public SalesWebMvcMySQLContext(DbContextOptions<SalesWebMvcMySQLContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
