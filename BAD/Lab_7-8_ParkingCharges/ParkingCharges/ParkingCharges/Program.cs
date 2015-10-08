using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCharges
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingChargerApp app = new ParkingChargerApp();

            //Test less than 3 hours -> result should be $2
            app.saveRegister("Milton", new TimeSpan(2,30,0), new DateTime(2015, 8, 20));
            //Test 4 hours -> result should be $2,50
            app.saveRegister("Gary", new TimeSpan(4, 0, 0), new DateTime(2015, 8, 20));
            //Test 20 hours -> result should be $10
            app.saveRegister("Stasnislav", new TimeSpan(20, 0, 0), new DateTime(2015, 8, 20));

            Console.WriteLine(app.printResume());
        }
    }
}

//Improvements that can be made: Search by name and search by date