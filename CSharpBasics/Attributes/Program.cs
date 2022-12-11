using System.Runtime.CompilerServices;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Customer customer = new Customer { Age = 34 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
        }
    }
    [ToTable("Customers")]
    class Customer
    {
        [RequiredProperty]
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    class CustomerDal
    {
        [Obsolete("Don't use it, use AddNew")]
        public void Add(Customer customer)
        {
            Console.WriteLine($"{customer.Id}, {customer.FirstName}, {customer.LastName}, {customer.Age} ");
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine($"{customer.Id}, {customer.FirstName}, {customer.LastName}, {customer.Age} ");
        }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
    public class RequiredPropertyAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class)]
    sealed class ToTableAttribute : Attribute
    {
        private string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}