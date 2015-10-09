using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTest1_2015_2_Milton
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet[] cats = new Pet[3];
            List<Pet> dogs = new List<Pet>();

            dogs.Add(new Pet("Marley", "American Akita" , 3,  "Milton", "22 Bentley WA", 0416960817));
            dogs.Add(new Pet("Warrior", "Armant", 1, "John", "11 Perth City WA", 0416963056));

            Console.WriteLine("Print dogs:");
            Console.WriteLine("");
            foreach (Pet d in dogs)
            {
                Console.WriteLine(d);
                Console.WriteLine("");
            }

            Console.WriteLine("===========================================================");

            cats[0] = new Pet("Pingo", "British Shorthair", "Marie", 0416961509);

            Console.WriteLine("Print Cats:");
            Console.WriteLine("");

            foreach (Pet c in cats)
            {
                Console.WriteLine(c);
                Console.WriteLine("");
            }

            Console.WriteLine("===========================================================");

            dogs.Insert(1, new Pet("Carlito", "Barbet", 5, "Caio", "15 Frementle", 0456905117));

            cats[1] = new Pet("Maylow", "Cyprus", "Caterine", 041691789);

            cats[0].AccountBalance = 250M;
            cats[1].AccountBalance = 230M;

            var orderbyName =
                from d in dogs
                let name = d.PetName
                orderby name
                select d;

            Console.WriteLine("Print dogs ordered by Name:");
            Console.WriteLine("");

            foreach (Pet d in orderbyName)
            {
                Console.WriteLine(d);
                Console.WriteLine("");
            }

            Console.WriteLine("===========================================================");

            Console.WriteLine("Print Cat showing new Balance");
            cats[0].Payment(200M);
            Console.WriteLine(cats[0]);
            Console.WriteLine("");

            Console.WriteLine("===========================================================");

            dogs.Add(new Pet("Pingado", "Basset Hound", 7, "Caique", "22 Bentley WA",   0420960800));
            dogs.Add(new Pet("Yanka", "Bearded Collie", 1, "Terry", "11 Perth City WA", 0430969056));

            var orderbyPhone =
                from d in dogs
                let contact = d.Contact
                orderby contact
                select d;

            Console.WriteLine("Print dogs ordered by Contact:");
            Console.WriteLine("");

            foreach (Pet d in orderbyPhone)
            {
                Console.WriteLine(d);
                Console.WriteLine(d.Contact);
                Console.WriteLine("");
            }

        }
    }
}
