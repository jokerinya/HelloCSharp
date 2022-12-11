using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tipi getir
            var type = typeof(DortIslem);
            // Instancei olustur
            var dortIslem2 = Activator.CreateInstance(type, 6, 7);
            // Method u cek
            MethodInfo methodInfo = dortIslem2.GetType().GetMethod("Topla2");
            // Calistir, null parametresine dikkat
            Console.WriteLine(methodInfo.Invoke(dortIslem2, null));
            Console.WriteLine("----------------------------------");
            // Classin bircok ogesine ulasilabiliriz
            var methods = type.GetMethods();
            // Methodlara
            foreach (var info in methods)
            {
                Console.WriteLine("Method adi: {0}", info.Name);
                // Methodun parametrelerine
                foreach (var param in info.GetParameters())
                {
                    Console.WriteLine("  -- Parametre adi: {0}", param.Name);
                }
                // Methodlarin varsa Attributelerine
                foreach (var attr in info.GetCustomAttributes())
                {
                    Console.WriteLine("  ** Attribute Name: {0}", attr.GetType().Name);
                    // Custom Attribute a gore de calistirdim
                    if (attr.GetType().Name == "MethodNameAttribute")
                    {
                        Console.WriteLine(info.Invoke(dortIslem2, null));
                    }
                }
            }

        }
    }
    class DortIslem
    {
        private int _sayi1;
        private int _sayi2;

        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public DortIslem()
        {

        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        [MethodName("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }

    [AttributeUsage(AttributeTargets.All)]
    public class MethodNameAttribute : Attribute
    {
        public MethodNameAttribute(string name)
        {

        }
    }
}