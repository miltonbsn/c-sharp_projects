using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_8_AccountInheritanceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {

           Console.WriteLine("SavingsAccount Test");

           SavingsAccount sa = new SavingsAccount(1000, 0.5M);
           Console.WriteLine("Initial balance is {0:C} " , sa.Balance);
           Console.WriteLine("Total Interest is {0:C} " , sa.CalculateInterestRate());
           sa.Credit(sa.CalculateInterestRate());
           Console.WriteLine("Final balance is {0:C} " , sa.Balance);

           Console.WriteLine();
           Console.WriteLine();


           Console.WriteLine("CheckingAccount Test");
           CheckingAccount ca = new CheckingAccount(1000M, 3.5M);
           Console.WriteLine("Initial balance is {0:C} ", ca.Balance);
           ca.Credit(100M);
           ca.Debit(50M);
           Console.WriteLine("Final balance is {0:C} ", ca.Balance);
           
        }
    }
}
