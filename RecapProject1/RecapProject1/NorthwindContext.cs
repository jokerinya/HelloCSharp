using RecapProject1.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapProject1
{
    // DB connection tool
    public class NorthwindContext : DbContext
    {
        // We didn't make object mapping, this will searh in DB Products table
        public DbSet<Product> Products { get; set; }
    }
}
