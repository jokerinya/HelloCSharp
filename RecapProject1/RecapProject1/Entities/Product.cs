using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapProject1.Entities
{
    public class Product
    // Name the props as in DB, for now we won't make object mapping
    // Only the items below will come from DB
    {
        public int ProductId { get; set; }
        // Foreign Key after private key
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        // In DB smalling --> Int16 in C#
        public Int16 UnitsInStock { get; set; }
        public string QuantityPerUnit { get; set; }
    }
}
