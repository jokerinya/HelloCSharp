using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StockManager stockManager = new StockManager();
            BuyStock buyStock = new BuyStock(stockManager);
            SellStock sellStock = new SellStock(stockManager);


            StockController stockController = new StockController();
            stockController.TakeOrder(buyStock);
            stockController.TakeOrder(sellStock);
            stockController.TakeOrder(buyStock);

            stockController.PlaceOrders();

            Console.ReadLine();

        }
    }

    class StockManager
    {
        private string _name = "Laptop";
        private int _quantity = 10;

        public void Buy()
        {
            Console.WriteLine($"Stock: {_name}, {_quantity} bought!");
        }

        public void Sell()
        {
            Console.WriteLine($"Stock: {_name}, {_quantity} sold!");
        }
    }

    interface IOrder
    {
        void Execute();
    }

    class BuyStock : IOrder
    {
        private StockManager _manager;

        public BuyStock(StockManager manager)
        {
            _manager = manager;
        }

        public void Execute()
        {
            _manager.Buy();
        }
    }

    class SellStock : IOrder
    {
        private StockManager _manager;

        public SellStock(StockManager manager)
        {
            _manager = manager;
        }

        public void Execute()
        {
            _manager.Sell();
        }
    }

    class StockController
    {
        List<IOrder> _orders = new List<IOrder>();

        public void TakeOrder(IOrder order)
        {
            _orders.Add(order);
        }

        public void PlaceOrders()
        {
            foreach (var order in _orders)
            {
                order.Execute();
            }

            _orders.Clear();
        }

    }


}
