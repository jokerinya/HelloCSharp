using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IoC-Inversion of control container implementation
            IKernel kernel = new StandardKernel();
            // Singleton will provide performance increase
            //kernel.Bind<IProductDal>().To<NhProductDal>().InSingletonScope();
            kernel.Bind<IProductDal>().To<EfProductDal>().InSingletonScope();

            ProductManager productManager = new ProductManager(kernel.Get<IProductDal>());

            productManager.Save();

            Console.ReadLine();
        }
    }

    interface IProductDal
    {
        void Save();
    }

    // EntityFramework product responsible class
    class EfProductDal : IProductDal
    {
        public void Save()
        {
            Console.WriteLine("Saved with EF");
        }
    }

    // Nhibernate product table responsible class
    class NhProductDal : IProductDal
    {
        public void Save()
        {
            Console.WriteLine("Saved with NHibernate");
        }
    }

    class ProductManager
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Save()
        {
            // Business
            _productDal.Save();
        }
    }
}
