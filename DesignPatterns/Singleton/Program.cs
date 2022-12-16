using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager customerManager = new CustomerManager(); // Error
            var customerManager = CustomerManager.CreateAsSingleTon();
            customerManager.Save();
        }
    }

    class CustomerManager
    {
        private static CustomerManager _customerManager;
        // This locker is especially useful when multithreading coding
        static object _lockeObject = new object();
        // 1. private constructor
        private CustomerManager()
        {

        }
        // 2. creater
        public static CustomerManager CreateAsSingleTon()
        {
            lock (_lockeObject)
            {
                if (_customerManager == null)
                {
                    _customerManager = new CustomerManager();
                }
            }
            return _customerManager;

            // Shorter
            //return _customerManager ?? (_customerManager = new CustomerManager());
        }

        public void Save()
        {
            Console.WriteLine("Saved!");
        }
    }
}
