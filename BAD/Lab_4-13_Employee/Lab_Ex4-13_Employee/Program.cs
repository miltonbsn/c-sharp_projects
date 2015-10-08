using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ex4_13_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Milton", "Bittencourt", 3800M);
            Employee employee2 = new Employee("Renata", "Tomaz", 2500M);

            // The result here has to be $45,600 (3800 * 12 = 45600)
            Console.WriteLine("{0} yearly salary is: {1:C} ", employee1.FirstName, employee1.getYearlySalary());
            // The result here has to be $30,000 (2500 * 12 = 30000)
            Console.WriteLine("{0} yearly salary is: {1:C} ", employee2.FirstName, employee2.getYearlySalary());

            // test set negative number - no change should be noted
            employee1.MonthlySalary = -100;
            Console.WriteLine("{0} yearly salary still the same as invalid opration was made: {1:C} ", employee1.FirstName, employee1.getYearlySalary());

            // * I am sure I should create a method inside Employee to increase the salary but the exercise did not asked.
            employee1.MonthlySalary = employee1.MonthlySalary + (System.Decimal.Multiply(employee1.MonthlySalary, 0.1M));
            employee2.MonthlySalary = employee2.MonthlySalary + (System.Decimal.Multiply(employee2.MonthlySalary, 0.1M));

            // The result here has to be $50,160 (3800 + 10% * 12 = 50160)
            Console.WriteLine("{0} yearly salary after 10% increase is: {1:C} ", employee1.FirstName, employee1.getYearlySalary());
            // The result here has to be $30,000 (2500 + 10% * 12 = 33000)
            Console.WriteLine("{0} yearly salary after 10% increase is: {1:C} ", employee2.FirstName, employee2.getYearlySalary());
        }
    }
}
