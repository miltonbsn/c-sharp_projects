using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_11_8_AccountInheritanceHierarchy
{
    class Account
    {
        private decimal balance;

        public Account(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public virtual void Credit(decimal value)
        {
            Balance = Balance + value;
        }

        public virtual string Debit(decimal value)
        {
            string result = "";

            if (Balance - value < 0)
            {

                Balance = Balance - value;
                result = "Debit amount exceeded account balance.";
            }
            else
            {
                Balance = Balance - value;
                result = "Operation Successful, new balance is: " + Balance;
            }
            return result;
        }

        public decimal Balance
        {
            set
            {
                if (value >= 0)
                    balance = value;
                else
                    throw new ArgumentException("Balance can not be negative");  
            }

            get
            {
                return balance;
            }

        }

    }
}
