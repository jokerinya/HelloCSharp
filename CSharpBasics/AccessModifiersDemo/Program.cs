using AccessModifiers;

namespace AccessModifiersDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Course course = new Course();
            // Bu referance eklememize ragmen gelmiyor. cunku internal
            //InternalDefaultClass course2 = new InternalDefaultClass();
        }
    }
}