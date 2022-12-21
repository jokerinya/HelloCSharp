using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Outer service will be added to our projects
            // How can we deal with dependency and abstraction?

            //ProductManager productManager = new ProductManager(new EdLogger());
            ProductManager productManager = new ProductManager(new Log4NetAdapter(new Log4Net()));
            productManager.Save();
            Console.ReadLine();
        }
    }

    class ProductManager
    {
        private ILogger _logger;

        public ProductManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Save()
        {
            _logger.Log("User data");
            Console.WriteLine("Saved");
        }
    }

    interface ILogger
    {
        void Log(string message);
    }

    class EdLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logged, {0}", message);
        }
    }

    // Let's say we want to change our Logger from the EdLogger to Log4Net
    // It came from NuGet and we can't touch Log4Net class (dll)
    class Log4Net
    {
        public void LogMessage(string message)
        {
            Console.WriteLine("Logged with log4net, {0}", message);
        }
    }

    // I create an adapter for it and call it's logger method inside this.
    class Log4NetAdapter : ILogger
    {
        private Log4Net _logger;

        public Log4NetAdapter(Log4Net logger)
        {
            _logger = logger;
        }

        public void Log(string message)
        {
            _logger.LogMessage(message);
        }
    }
}
