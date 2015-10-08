using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_9_RoudingToNearestInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            RoundApp app = new RoundApp();

            while (true)
            {
                Console.Write("Enter a double: ");
                double value = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("value: " + value);
                Console.WriteLine("Int: " + app.RoundToTheNearestInteger(value));
            }
        }
    }
}
