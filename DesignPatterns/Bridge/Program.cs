using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.MessageSenderBase = new MailSender();
            customerManager.MessageSenderBase = new SMSSender();
            customerManager.UpdateCustomer();
            Console.ReadLine();
        }
    }

    abstract class MessageSenderBase
    {
        public void Save()
        {
            Console.WriteLine("Message Saved!");
        }

        public abstract void Send(Body body);
    }

    class Body
    {
        public string Title { get; set; }
        public string Text { get; set; }
    }


    class MailSender : MessageSenderBase
    {
        public override void Send(Body body)
        {
            Console.WriteLine("{0} was sent via Mail Sender", body.Title);
        }
    }

    class SMSSender : MessageSenderBase
    {
        public override void Send(Body body)
        {
            Console.WriteLine("{0} was sent via SMS Sender", body.Title);
        }
    }


    class CustomerManager
    {
        public MessageSenderBase MessageSenderBase;


        public void UpdateCustomer()
        {
            MessageSenderBase.Send(new Body { Title = "Customer updated about the course" });
            Console.WriteLine("Customer Manager update jobs");
        }
    }
}
