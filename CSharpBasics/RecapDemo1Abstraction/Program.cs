namespace RecapDemo1Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new FileLogger();
            customerManager.Add();
        }
        class CustomerManager
        {
            public ILogger Logger { get; set; }
            public void Add()
            {
                Logger.Log("Customer Manager");
                Console.WriteLine("Customer Added!");
            }

        }
        class DatabaseLogger : ILogger
        {
            public void Log(string message)
            {
                Console.WriteLine(message + " Database Logger");
            }
        }

        class FileLogger : ILogger
        {
            public void Log(string message)
            {
                Console.WriteLine(message + " file Logger");
            }
        }

        interface ILogger
        {
            void Log(string message);
        }
    }
}