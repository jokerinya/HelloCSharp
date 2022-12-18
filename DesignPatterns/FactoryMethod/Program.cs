using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // One of the most used
            // User is not depended to LoggerFactory or Logger 
            CustomerManager customerManager = new CustomerManager(new LoggerFactory());
            customerManager.Save();
        }
    }
    public class LoggerFactory : ILoggerFactory
    {
        // Give me a logger according to bussiness requirements 
        public ILogger CreateLogger()
        {
            return new EdLogger();
        }
    }
    public interface ILoggerFactory
    {
        ILogger CreateLogger();
    }
    public interface ILogger
    {
        void Log();
    }
    public class EdLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with EdLogger");
        }

    }
    public class CustomerManager
    {
        private ILoggerFactory _loggerFactory;
        public CustomerManager(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }
        public void Save()
        {
            Console.WriteLine("Saved!");
            //ILogger logger = new LoggerFactory().CreateLogger();
            ILogger logger = _loggerFactory.CreateLogger();
            logger.Log();
        }
    }
}
