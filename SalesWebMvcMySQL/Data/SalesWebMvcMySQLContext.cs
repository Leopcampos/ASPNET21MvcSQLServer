using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvcMySQL.Models;

namespace SalesWebMvcMySQL.Data
{
    public class SalesWebMvcMySQLContext : DbContext
    {
        public SalesWebMvcMySQLContext (DbContextOptions<SalesWebMvcMySQLContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvcMySQL.Models.Department> Department { get; set; }
    }
}
