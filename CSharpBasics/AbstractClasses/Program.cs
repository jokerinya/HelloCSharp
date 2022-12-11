namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new SqlServer();
            database.Add();
            database.Delete();
            Database database1 = new MysqlServer();
            database1.Add();
            database1.Delete();
        }

        abstract class Database
        {
            public virtual void Add()
            {
                Console.WriteLine("Added by default");
            }
            // This must be initilaze from children
            public abstract void Delete();
        }
         
        class SqlServer : Database
        {
            public override void Delete()
            {
                Console.WriteLine("Deleted by SqlServer");
            }
        }

        class MysqlServer : Database
        {
            public override void Add()
            {
                Console.WriteLine("Added by Mysql server");
            }
            public override void Delete()
            {
                Console.WriteLine("Deleted by Mysql Server");
            }
        }
    }
}