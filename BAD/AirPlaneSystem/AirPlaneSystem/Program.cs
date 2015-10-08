using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPlaneSystem
{
    class Program
    {
        private const int FIRST_CLASS = 1;
        private const int ECONOMY_CLASS = 2;
        private const int YES = 1;
        private const int NO = 2;
        private const string ALL_FULL = "Sorry, all sections are full! Next fligth leaves in 3 hours\n\n";
        private const string THANKS_MSG = "Thank you for flying with us\n\n";

        static void Main(string[] args)
        {
            Plane plane = new Plane();

            while (true)
            {

                Console.WriteLine("Please type 1 for First Class or 2 for Second Class:");
                int choice = 0;

                if (int.TryParse(Console.ReadLine(), out choice))
                {

                    bool firstClass;

                    switch (choice)
                    {
                        case FIRST_CLASS:
                            firstClass = true;
                            choice = processRegister(plane, choice, firstClass);
                            break;

                        case ECONOMY_CLASS:
                            firstClass = false;
                            choice = processRegister(plane, choice, firstClass);
                            break;

                        default:
                            Console.WriteLine("Please, type 1 or 2 only");
                            break;
                    }

                }
            }              
        }

        private static int processRegister(Plane plane, int choice, bool firstClass)
        {
            bool full = plane.registerPlace(firstClass);
            if (full)
            {
                checkOtherClass(plane, ref choice, firstClass, ref full);
            }
            else
            {
                print(THANKS_MSG);
            }
            return choice;
        }

        

        private static void checkOtherClass(Plane plane, ref int choice, bool firstClass, ref bool full)
        {
            Console.WriteLine("\nSorry, this class is full! Do you wish be realocated to another class?");
            Console.WriteLine("Press 1 if YES or 2 if NO");
            choice = 0;

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case YES:
                        full = plane.registerPlace(!firstClass);
                        string msg = full ? ALL_FULL : THANKS_MSG;
                        print(msg);
                        break;

                    case NO:
                        Console.WriteLine("Next fligth leaves in 3 hours\n\n");
                        break;

                    default:
                        Console.WriteLine("Please, type 1 or 2 only");
                        break;
                }
            }

        }
        
        private static void print(string msg)
        {
            Console.WriteLine(msg);
        }

    }
}
