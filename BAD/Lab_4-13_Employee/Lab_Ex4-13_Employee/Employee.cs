using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_Ex4_13_Employee
{
    class Employee
    {
        private string firstName;
        private string lastName;
        private decimal monthlySalary;

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(string firstName, string lastName, decimal monthlySalary)
        {
            FirstName = firstName;
            LastName = lastName;
            MonthlySalary = monthlySalary;
        }

        public decimal MonthlySalary
        {
            get
            {
                return monthlySalary;
            }

            set
            {
                if (value >= 0)
                {
                    monthlySalary = value;
                }
            }
        }

        public decimal getYearlySalary()
        {
            return monthlySalary * 12;
        }

    }
}
