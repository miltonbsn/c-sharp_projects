using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ex3_29_TableDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, square, cube;

            Console.WriteLine("Number\tSquare\tCube");

            for (int i = 0; i <= 10; i++)
            {
                number = i;
                square = i * i;
                cube = i * i * i;
                Console.WriteLine("{0}\t{1}\t{2}", number, square, cube);
            }
        }
    }
}
