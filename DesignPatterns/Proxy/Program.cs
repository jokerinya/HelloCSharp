using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //CreditBase creditManager = new CreditManager();
            // This will wait for 5 sec for both operation but proxy will return immediately
            CreditBase creditManager = new CreditManagerProxy();
            Console.WriteLine(creditManager.Calculate());
            Console.WriteLine(creditManager.Calculate());
            Console.ReadLine();
        }
    }

    abstract class CreditBase
    {
        public abstract int Calculate();
    }

    class CreditManager : CreditBase
    {
        public override int Calculate()
        {
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result *= i;
                Thread.Sleep(1000);
            }
            return result;
        }
    }

    class CreditManagerProxy : CreditBase
    {
        private CreditManager _creditManager;
        private int _cahcedValue;

        public override int Calculate()
        {
            if (_creditManager == null)
            {
                _creditManager = new CreditManager();
                _cahcedValue = _creditManager.Calculate();
            }

            return _cahcedValue;
        }
    }
}
