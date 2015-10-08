using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateWordRemoval
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type something and we will find the non duplicated words to you:");
            String text = Console.ReadLine();
            List<string> words = text.Split().ToList();

            var nomDuplicatedWords =
                from word in words
                let lowerword = word.ToLower()
                group lowerword by lowerword into nonduplicated
                where nonduplicated.Count() <= 1
                select nonduplicated.First();

            foreach (var w in nomDuplicatedWords)
                Console.WriteLine("{0}", w);
        }

    }
}

// one One Two One TWO two four five six Six SIX SEVEN nine TEN teN nIne

//var startsWithR =
//    from item in items
//    let uppercaseString = item.ToUpper()
//    where uppercaseString.StartsWith( "R" )
//    orderby uppercaseString
//    select uppercaseString;