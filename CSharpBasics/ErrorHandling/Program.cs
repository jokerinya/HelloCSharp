using UtilClassLibrary;

namespace ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            try
            {
                Find();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            // Yukaridakinin kisa hali bu bir suru kullanabiliriz bu sayede
            HandleException(() =>
            {
                Find();
            });
            // Find herhangi bir method bunu cevreliyoruz
            HandleException(() => { Find(); });

            Console.WriteLine("====Func Ornegi====");
            // iki tane int aliyor, ve int donuyor. En son eleman hep donen demek bu bi
            // delegasyon yapisi aslinda
            Func<int, int, int> myAdd = Topla;
            Console.WriteLine(myAdd(3, 5));
            // Baska bir ornek
            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            Console.WriteLine(getRandomNumber());
            Console.WriteLine(getRandomNumber());
            Console.WriteLine(getRandomNumber());
            // Daha kisasi
            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
            Console.WriteLine(getRandomNumber2());
            Console.WriteLine(getRandomNumber2());
            Console.WriteLine(getRandomNumber2());
        }

        // Genel bir exception handler
        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> names = new List<string> { "ali", "veli", "deli" };
            if (!names.Contains("kemal"))
            {
                throw new CustomRecordNotFoundException("Kemali bulamadim");
            }
        }

        // bunu Func ile cagirabiliyoruz
        private static int Topla(int num1, int num2)
        {
            return num1 + num2;
        }

    }
}