using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Evrak takip sistemi mesela

            // Create all managers
            Manager manager = new Manager();
            VicePresident vicePresident = new VicePresident();
            President president = new President();

            // create hierarchy
            manager.SetSuccessor(vicePresident);
            vicePresident.SetSuccessor(president);

            // Create Expenses
            Expense expenseSmall = new Expense { Amount = 50, Detail = "Small amount!" };
            Expense expenseMedium = new Expense { Amount = 500, Detail = "Medium amount!" };
            Expense expenseLarge = new Expense { Amount = 5000, Detail = "Large amount!" };

            // Call for only manager
            manager.HandleExpense(expenseSmall);
            manager.HandleExpense(expenseMedium);
            manager.HandleExpense(expenseLarge);

            /**************************/
            Console.ReadLine();
        }
    }

    class Expense
    {
        public string Detail { get; set; }
        public decimal Amount { get; set; }
    }

    abstract class ExpenseHandlerBase
    {
        protected ExpenseHandlerBase Successor;

        public abstract void HandleExpense(Expense expense);

        public void SetSuccessor(ExpenseHandlerBase sucessor)
        {
            Successor = sucessor;
        }
    }

    class Manager : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount <= 100)
            {
                Console.WriteLine("Manager Handled the expense, amount {0}, details: {1}", expense.Amount, expense.Detail);
            }
            else if (Successor != null)
            {
                Successor.HandleExpense(expense);
            }
        }
    }

    class VicePresident : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount > 100 && expense.Amount <= 1000)
            {
                Console.WriteLine("Vice President Handled the expense, amount {0}, details: {1}", expense.Amount, expense.Detail);
            }
            else if (Successor != null)
            {
                Successor.HandleExpense(expense);
            }
        }
    }

    class President : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount > 1000)
            {
                Console.WriteLine("President Handled the expense, amount {0}, details: {1}", expense.Amount, expense.Detail);
            }
        }
    }
}
