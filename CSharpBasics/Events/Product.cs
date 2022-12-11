using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    // delege olustur
    public delegate void StockControl();
    public class Product
    {
        private int _stock;
        public Product(int stock)
        {
            _stock = stock;
        }

        // delegeyi event turunde bir param olarak classa ekle
        public event StockControl StockControlEvent;
        public string ProductName { get; set; }
        public int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
                // deger 15 den kucukse ve bu degere abone olunmussa demek
                if (value <= 15 && StockControlEvent != null)
                {
                    StockControlEvent();
                }
            }
        }

        public void Sell(int amount)
        {
            Stock -= amount;
            Console.WriteLine("{1} Stock amount: {0}", Stock, ProductName);
        }
    }
}
