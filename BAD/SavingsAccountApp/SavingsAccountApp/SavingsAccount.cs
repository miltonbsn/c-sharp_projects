using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SavingsAccountApp
{
    class SavingsAccount
    {
        private static double annualInterestRate;
        private double savingsBalance;

        public SavingsAccount(double savingsBalance)
        {
            this.savingsBalance = savingsBalance;
        }

        public double CalculateMonthlyInterest()
        {
            return savingsBalance + ((savingsBalance * annualInterestRate) / 12);
        }

        public static void ModifyInterestRate(double newAnnualInterestRate)
        {
            annualInterestRate = newAnnualInterestRate;
        }


    }
}
