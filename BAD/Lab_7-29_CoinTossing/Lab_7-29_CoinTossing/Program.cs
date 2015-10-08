using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_29_CoinTossing
{
    class Program
    {
        static void Main(string[] args)
        {
            CoinTossingApp app = new CoinTossingApp();

            while (true)
            {
                Console.WriteLine("Press anything to 'Toss coin': ");
                Console.ReadLine();
                string coin = app.Flip();
                Console.WriteLine("Result: " + coin);
                Console.WriteLine("Heads: " + app.QtHead);
                Console.WriteLine("Tails: " + app.QtTail);
                Console.WriteLine("Round: " + app.Rounds);

            }
        }
    }
}
