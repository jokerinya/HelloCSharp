using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    internal class ProductDal
    {
        public List<Product> GetAll()
        {
            // IDisposable implemente ediyor context nesnesi, isi bitince cope atilmasi icin boyle yapiyoruz,
            // cunku cok pahali bir nesne, using bitiminde garbage collector gelmeden dispose edilir
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.ToList();
            }
        }

        public List<Product> GetByName(string key)
        {
            // IDisposable implemente ediyor context nesnesi, isi bitince cope atilmasi icin boyle yapiyoruz,
            // cunku cok pahali bir nesne, using bitiminde garbage collector gelmeden dispose edilir
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.Name.Contains(key)).ToList();
            }
        }

        public List<Product> GetByUnitPrice(decimal price)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= price).ToList();
            }

        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p =>  p.UnitPrice >= min && p.UnitPrice <= max).ToList();
            }

        }

        public Product GetById(int id)
        {
            using(ETradeContext context = new ETradeContext())
            {
                return context.Products.FirstOrDefault(p => p.Id == id);
            }
        }

        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                //context.Products.Add(product); Bu da olur asagidaki de olur
                var entity = context.Entry(product);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
