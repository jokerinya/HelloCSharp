using System.Collections;

namespace UtilClassLibrary
{
    public class ConsoleWriters
    {
        public static void WriteToConsole(string[] strings)
        {
            Console.WriteLine();
            foreach (string s in strings)
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine();
        }

        public static void WriteToConsole(ArrayList arrayList)
        {
            Console.WriteLine();
            foreach (var s in arrayList)
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine();
        }
        
        public static void WriteToConsole(IList list)
        {
            Console.WriteLine();
            foreach (var s in list)
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine();
        }

    }
}