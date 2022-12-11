namespace Delegates
{
    // param almayan ve birsey donmeyenlere delegelik yapiyor
    public delegate void MyDelegate();
    // 2.version paramli
    public delegate void MyDelegate2(string str);
    // 3. version, en son verilen delegeyi calistirir.
    public delegate int MyDelegate3(int number1, int number2);
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customer = new CustomerManager();
            // Delegeye bu methodu atadik
            MyDelegate myDelegate = customer.SendMessage;
            // uzerine baska methodlarda atanabilir
            myDelegate += customer.ShowAllert;
            // yada cikartilabilir
            myDelegate -= customer.SendMessage;
            // Ikisini bir cagiriyor
            myDelegate();
            Console.WriteLine("------2. Version-------");
            MyDelegate2 myDelegate2 = customer.SendMessage2;
            myDelegate2 += customer.ShowAllert2;
            myDelegate2("Her iki method da bunu yazacak");
            Console.WriteLine("------3. Version-------");
            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Carp;
            Console.WriteLine(myDelegate3(1, 0));
        }
    }

    class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Bu bir mesajdir");
        }
        public void ShowAllert()
        {
            Console.WriteLine("Be careful");
        }
        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAllert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }
    public class Matematik
    {
        public int Topla(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Carp(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}