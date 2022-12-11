using UtilClassLibrary;

namespace RefAndValueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = number1;

            number1 = 30;
            Console.WriteLine(number2);

            string[] cities = { "ankara", "istanbul", "antalya", "kamerun" };
            string[] cities2 = cities;
            Console.WriteLine("\n=====Before Change=====\n");
            ConsoleWriters.WriteToConsole(cities);
            ConsoleWriters.WriteToConsole(cities2);
            Console.WriteLine("\n=====After Change=====\n");
            cities[0] = "new york";
            ConsoleWriters.WriteToConsole(cities);
            ConsoleWriters.WriteToConsole(cities2);

            Console.WriteLine("\n=====After Change=====\n");




        }
        //static void WriteToConsole(string[] strings)
        //{
        //    Console.WriteLine();
        //    foreach (string s in strings)
        //    {
        //        Console.Write($"{s} ");
        //    }
        //    Console.WriteLine();
        //}
    }
}