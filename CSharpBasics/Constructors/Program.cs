namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();  // Bu birinci yontem
            product.Id = 1;
            product.Name = "Test";
            // Bu ikinci yontem, Ustekinin kisa yolu
            Product product1 = new Product { Id = 2, Name = "Test2" };
            // Bu da constructor ile yapilan 3ncu yontem
            Product product2 = new Product(3, "Test3");

            // Cok onemli dependency injection
            ILogger logger = new SQLLogger();
            logger = new FileLogger();  // Degistiredebilirim.
            EmployeeManager employeeManager = new EmployeeManager(logger);
            employeeManager.Add();

            PersonManger personManger = new PersonManger("A new Product");
            personManger.Add();

        }
    }
    class PersonManger : BaseClass
    {
        // Javadaki super yapisina benziyor.
        // gelen degeri bir uste iletiyoruz
        // base'in constructor ini elemanli olarak cagirir
        public PersonManger(string entity) : base(entity)
        {
        }

        public void Add()
        {
            Console.WriteLine("Person manager added");
            Message(); // Base classdan gelen method
        }
    }

    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }
    }

    class SQLLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("SQL Logger Logged");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("File Logger Logged");
        }
    }

    interface ILogger
    {
        void Log();
    }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private int _id;
        private string _name;
        public Product()
        {

        }
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
    }
}