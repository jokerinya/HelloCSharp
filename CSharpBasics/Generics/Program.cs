namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "istanbul", "izmir");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> customers = utilities.BuildList<Customer>(new Customer { FirstName = "Dane" }, new Customer { FirstName = "Ben" });
            foreach (var item in customers)
            {
                Console.WriteLine(item.FirstName);
            }


        }

        class Utilities
        {
            public List<T> BuildList<T>(params T[] items)
            {
                return new List<T>(items);
            }

        }


        class Customer : IEntity
        {
            public string FirstName { get; set; }
        }

        class Product : IEntity
        {

        }

        interface IEntity
        {

        }

        interface IProductDal : IRepository<Product>
        {
        }

        interface ICustomerDal : IRepository<Customer>
        {
        }
        // class olmali ve newlenebilmeli diye kisit koyuyoruz new() her zaman en sonda olmali
        //interface IRepository<T> where T : struct // bu ise deger tiplere karsilik gelir
        interface IRepository<T> where T : class, IEntity, new()
        {
            List<T> GetAll();
            T Get(int id);
            void Add(T t);
            void Delete(T t);
            void Update(T t);
        }

        class ProductDal : IProductDal
        {
            public void Add(Product t)
            {
                throw new NotImplementedException();
            }

            public void Delete(Product t)
            {
                throw new NotImplementedException();
            }

            public Product Get(int id)
            {
                throw new NotImplementedException();
            }

            public List<Product> GetAll()
            {
                throw new NotImplementedException();
            }

            public void Update(Product t)
            {
                throw new NotImplementedException();
            }
        }
    }
}