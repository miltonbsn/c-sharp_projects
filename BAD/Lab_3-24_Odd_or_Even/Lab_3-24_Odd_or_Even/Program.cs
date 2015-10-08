using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_24_Odd_or_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            int option, value;

            while (!done)
            {

                Console.Write("Press (1) to test a number or (2) to exit: ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Enter a integer: ");
                        value = Convert.ToInt32(Console.ReadLine());

                        if(value % 2 == 0)
                        {
                            Console.WriteLine("{0} is even.", value);
                        }
                        else
                        {
                            Console.WriteLine("{0} is odd.", value);
                        }
                        break;

                    case 2:
                        done = true;
                        break;
                }

            }
        }
    }
}
