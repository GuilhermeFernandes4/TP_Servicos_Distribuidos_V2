using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using House_API;

    public class ProductDBContext : DbContext
    {
        public ProductDBContext (DbContextOptions<ProductDBContext> options)
            : base(options)
        {
        }

        public DbSet<House_API.Product> Product { get; set; } = default!;
    }
