using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerMaganer customerMaganer = new CustomerMaganer();
            customerMaganer.Save();
            Console.ReadLine();
        }
    }

    class Logging : ILogging
    {
        public void Log()
        {
            Console.WriteLine("Logged");
        }
    }

    internal interface ILogging
    {
        void Log();
    }

    class Cahching : ICahching
    {
        public void Cache()
        {
            Console.WriteLine("Cached");
        }
    }

    internal interface ICahching
    {
        void Cache();
    }

    class Authorize : IAuthorize
    {
        public void CheckUser()
        {
            Console.WriteLine("User checked");
        }
    }

    internal interface IAuthorize
    {
        void CheckUser();
    }

    class Validating : IValidating
    {
        public void Validate()
        {
            Console.WriteLine("Info validated");
        }
    }

    internal interface IValidating
    {
        void Validate();
    }

    class CustomerMaganer
    {
        private CrossCuttingConcernsFacade _concerns;
        public CustomerMaganer()
        {
            _concerns = new CrossCuttingConcernsFacade();
        }

        public void Save()
        {
            _concerns.Cahching.Cache();
            _concerns.Authorize.CheckUser();
            _concerns.Logging.Log();
            _concerns.Validating.Validate();
            Console.WriteLine("Saved");
        }
    }

    // Create this and only change here for dependencies
    class CrossCuttingConcernsFacade
    {
        public ILogging Logging;
        public ICahching Cahching;
        public IAuthorize Authorize;
        // Validating added later
        public IValidating Validating;

        public CrossCuttingConcernsFacade()
        {
            Logging = new Logging();
            Cahching = new Cahching();
            Authorize = new Authorize();
            Validating = new Validating();
        }
    }
}
