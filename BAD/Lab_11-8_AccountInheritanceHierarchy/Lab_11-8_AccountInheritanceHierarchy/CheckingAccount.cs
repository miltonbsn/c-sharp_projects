using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_11_8_AccountInheritanceHierarchy
{
    class CheckingAccount : Account
    {

        private decimal _fee;

        public CheckingAccount(decimal initialBalance, decimal fee) : base(initialBalance)
        {
            Fee = fee;   
        }

        public override void Credit(decimal amount)
        {
            base.Credit(amount);
            Balance -= Fee;
        }

        public override string Debit(decimal amount)
        {
            return base.Debit(amount + Fee);
        }

        public decimal Fee
        {
            get { return _fee; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Fee can not be negative");
                else
                    _fee = value;
            }
        }
    }
}
