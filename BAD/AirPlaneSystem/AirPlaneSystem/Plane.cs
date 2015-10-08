using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirPlaneSystem
{
    class Plane
    {
        private bool[] seats; 

        public Plane ()
        {
            this.seats = new bool[10] {false, false, false, false, false,
                                       false, false, false, false, false};
        }

        public bool registerPlace(bool firstClass)
        {
            bool busy = true;
            int limit = firstClass ? 5 : 10;

            for (int i = 0; i < limit; i++)
            {
                bool seat = this.seats[i];
                if (!seat)
                {
                    this.seats[i] = true;
                    busy = false;
                    break;
                }
            }
            
            return busy;
        }

        public string getPlaneStatus()
        {
            string status = "";

            for (int i = 0; i < this.seats.Length; i++)
            {
                status += "[" + (i+1) + "\t] " + (this.seats[i] ? "Available " : "Occupied" )+ "\n";
            }

            return status;
        }

    }
}
