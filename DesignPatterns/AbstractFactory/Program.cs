using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new Factory1());
            //ProductManager productManager = new ProductManager(new Factory2());
            productManager.GetAll();
            Console.ReadLine();

        }
    }
    public abstract class Logging
    {
        public abstract void Log(string message);
    }

    public abstract class Caching
    {
        public abstract void Cache(string message);
    }

    public class Log4NetLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logged with log4net");
        }
    }

    public class NLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logged with nlogger");
        }
    }

    public class MemCache : Caching
    {
        public override void Cache(string message)
        {
            Console.WriteLine("Cached with memcache");
        }
    }

    public class RedisCache : Caching
    {
        public override void Cache(string message)
        {
            Console.WriteLine("Cached with redis cahce");
        }
    }

    public abstract class CrossCuttingConcernsFactory
    {
        public abstract Logging CreateLogger();
        public abstract Caching CreateCaching();
    }

    public class Factory1 : CrossCuttingConcernsFactory
    {
        public override Caching CreateCaching()
        {
            return new RedisCache();
        }

        public override Logging CreateLogger()
        {
            return new Log4NetLogger();
        }
    }

    public class Factory2 : CrossCuttingConcernsFactory
    {
        public override Caching CreateCaching()
        {
            return new RedisCache();
        }

        public override Logging CreateLogger()
        {
            return new NLogger();
        }
    }

    public class ProductManager
    {
        private CrossCuttingConcernsFactory _crossCuttingConcernsFactory;

        private Logging _logging;
        private Caching _caching;

        public ProductManager(CrossCuttingConcernsFactory crossCuttingConcernsFactory)
        {
            _crossCuttingConcernsFactory = crossCuttingConcernsFactory;
            _caching = _crossCuttingConcernsFactory.CreateCaching();
            _logging = _crossCuttingConcernsFactory.CreateLogger();
        }

        public void GetAll()
        {
            _logging.Log("Logged");
            _caching.Cache("Cached");
            Console.WriteLine("Products listed!");
        }
    }
}
