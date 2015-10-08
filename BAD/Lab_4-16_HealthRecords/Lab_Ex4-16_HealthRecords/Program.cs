using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ex4_16_HealthRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            HealthProfile p1 = new HealthProfile("Milton", "Bittencourt", "Male",
            20, 8, 1989, 1.76, 79.0);

           Console.WriteLine(p1.getSummary());

           Console.WriteLine("\nBMI reference values");
           Console.WriteLine("Underweight:\tless than 18.5\nNormal:\t\tbetween 18.5 and 24.9\nOverweight:\tbetween 25 and 29.9\nObese:\t\t30 or greater");

        }
    }
}
