namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    // default access modifier internaldir. Baska namespace(Assembly)den ulasmak icin
    // public olmali
    public class Course
    {
        // private sadece tanimlandigi block icinde gecerli olur
        private int Id { get; set; }
        // Private arti inherit eden class da da gosterir
        protected int ProId { get; set; }
        public void Save()
        {
            // Id ve ProId geliyor burada
            Id = 0;
            ProId = 0;
        }
    }

    class InternalDefaultClass
    {
        public int Id { get; set; }
    }


    class MySQLCourse : Course
    {
        protected void Add()
        {
            // Id gelmiyor, ProId geliyor
            ProId++;
        }
    }
}