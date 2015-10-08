using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_7_29_CoinTossing
{
    class CoinTossingApp
    {
        public int QtHead { get; set; }
        public int QtTail { get; set; }
        public int Rounds { get { return QtHead + QtTail; } }

        public CoinTossingApp()
        {
        }

        public string Flip()
        {
            Random random = new Random();
            bool result = random.Next(2) == 0;
            string coin = "";
            if (result)
            {
                QtHead += 1;
                coin = "Head";
            }
            else
            {
                QtTail += 1;
                coin = "Tail";
            }
            return coin;
        }

    }
}
