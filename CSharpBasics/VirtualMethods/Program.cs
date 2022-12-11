namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MySql mySql = new MySql();
            mySql.Add();
            SqlServer sqlServer= new SqlServer();
            sqlServer.Add();
        }

        class Database
        {
            public virtual void Add()
            {
                Console.WriteLine("Added by default");
            }
            public void Update() 
            {
                Console.WriteLine("Deleted by default");
            }
        }

        class MySql: Database
        {
            public override void Add()
            {
                base.Add();
                Console.WriteLine("Added by MySQL");
            }
        }
        class SqlServer: Database
        {

        }
    }
}