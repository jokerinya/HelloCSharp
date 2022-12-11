using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ETradeContext : DbContext
    {
        // Tablolarda Products'i ariyor ve eslesiyor
        public DbSet<Product> Products { get; set; }
    }
}
