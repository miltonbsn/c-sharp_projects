using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsAccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount c1 = new SavingsAccount(2000);
            SavingsAccount c2 = new SavingsAccount(3000);

            SavingsAccount.ModifyInterestRate(0.04);

            Console.WriteLine(c1.CalculateMonthlyInterest());
            Console.WriteLine(c2.CalculateMonthlyInterest());

            SavingsAccount.ModifyInterestRate(0.05);

            Console.WriteLine(c1.CalculateMonthlyInterest());
            Console.WriteLine(c2.CalculateMonthlyInterest());

        }
    }
}
