using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_11_8_AccountInheritanceHierarchy
{
    class SavingsAccount : Account
    {

        private decimal interesteRate;

        public SavingsAccount(decimal initialBalance, decimal initialInteresteRate): base(initialBalance)
        {
            InterestRate = initialInteresteRate;
        }

        public decimal CalculateInterestRate()
        {
            return Balance * InterestRate;
        }

        public decimal InterestRate
        {
            get{ return interesteRate; }
            set{
                if (value < 0)
                    throw new ArgumentException("Interest rate can not be negative");
                else
                    interesteRate = value;
            }
        }
    }
}
