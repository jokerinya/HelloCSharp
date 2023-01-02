using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // These two nixon will get same class for Nixon key
            Camera nixon1 = Camera.GetCamera("Nixon");
            Console.WriteLine($"1st camera's guid is : {nixon1.Id}");

            Camera nixon2 = Camera.GetCamera("Nixon");
            Console.WriteLine($"2nd camera's guid is : {nixon2.Id}");

            // Now this is a different instance, we can understand it from the guid
            Camera canon1 = Camera.GetCamera("Canon");
            Console.WriteLine($"#nd camera's guid is : {canon1.Id}");



            Console.ReadLine();
        }
    }

    class Camera
    {
        static Dictionary<string, Camera> _cameras = new Dictionary<string, Camera>();

        static object _lock = new object();

        private string brand;
        public Guid Id { get; set; }

        private Camera()
        {
            Id = Guid.NewGuid();
        }

        public static Camera GetCamera(string brand)
        {
            lock (_lock)
            {
                if (!_cameras.ContainsKey(brand))
                {
                    _cameras.Add(brand, new Camera());
                }
                return _cameras[brand];
            }
        }

    }
}
