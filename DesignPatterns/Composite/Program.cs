using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Order
            Employee ibrahim = new Employee { Name = "Ibrahim Sakaci" };
            Employee john = new Employee { Name = "John Doe" };
            Employee tina = new Employee { Name = "Tina Levy" };
            Employee mosh = new Employee { Name = "Mosh Mamba" };

            ibrahim.AddSubordinate(john);
            ibrahim.AddSubordinate(tina);
            john.AddSubordinate(mosh);

            Contractor louis = new Contractor { Name = "Louis Griffin" };
            tina.AddSubordinate(louis);

            Console.WriteLine(ibrahim.Name);
            foreach (Employee manager in ibrahim)
            {
                Console.WriteLine("  " + manager.Name);
                foreach (var employee in manager)
                {
                    Console.WriteLine("\t" + employee.Name);
                }

            }

            Console.ReadLine();

        }
    }

    interface IPerson
    {
        string Name { get; set; }
    }

    class Employee : IPerson, IEnumerable<IPerson>
    {
        List<IPerson> _subordinates = new List<IPerson>();

        public void AddSubordinate(IPerson person)
        {
            _subordinates.Add(person);
        }

        public void RemoveSubordinate(IPerson person)
        {
            _subordinates.Remove(person);
        }

        public IPerson GetSubordinate(int index)
        {
            return _subordinates[index];
        }


        public string Name { get; set; }

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var subordinate in _subordinates)
            {
                yield return subordinate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Contractor : IPerson
    {
        public string Name { get; set; }
    }
}
