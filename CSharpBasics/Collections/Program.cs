using System.Collections;
using UtilClassLibrary;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ArrayListExample();
            ListExample();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("1", "bir");
            ConsoleWriters.WriteToConsole(new ArrayList(dictionary.Keys));

        }

        private static void ListExample()
        {
            // List 
            List<string> list = new List<string>();
            list.Add("ankara");
            // list.Add(0); // bu patlar
            List<Customer> customers = new List<Customer>
            {
                new Customer() {Id = 1, Name = "One" },
                new Customer() {Id = 3, Name = "Three" },
                new Customer() {Id = 2, Name = "Two"}
            };

            customers.Remove(customers[0]);
            customers.RemoveAll(c => c.Name == "Two");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
        }

        private static void ArrayListExample()
        {
            Console.WriteLine("=========Array List icine her cesit alabilir=============");
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Ankara");  // her cesit ekler
            arrayList.Add(0);  // integer
            arrayList.Add('A');  // chars
            arrayList.Add(true);  // bool
            arrayList.Add("Ankara");  // duplicate'e izin verir
            ConsoleWriters.WriteToConsole(arrayList);
        }


    }
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}