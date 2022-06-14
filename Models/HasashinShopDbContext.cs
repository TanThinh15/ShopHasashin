using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HasashinShop.Models
{
    public class HasashinShopDbContext : DbContext
    {
        public HasashinShopDbContext(DbContextOptions<HasashinShopDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
