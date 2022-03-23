using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    class Program
    {
        static void Main(string[] args)
        {

            // Keep the console window open
            Console.WriteLine("----------------------");
            ElementaryOperations.BasicOperation(1, 2, '+');
            ElementaryOperations.BasicOperation(1, 2, '-');
            ElementaryOperations.BasicOperation(1, 2, '*');
            ElementaryOperations.BasicOperation(1, 2, '/');
            ElementaryOperations.BasicOperation(1, 0, '/');
            ElementaryOperations.BasicOperation(1, 2, 'l');
            ElementaryOperations.IntegerDivision(3, 4);
            ElementaryOperations.Pow(2, 4);
            Console.WriteLine("");
            SpeakingClock.GoodDay(4);
            SpeakingClock.GoodDay(10);
            SpeakingClock.GoodDay(12);
            SpeakingClock.GoodDay(15);
            SpeakingClock.GoodDay(19);
            Console.WriteLine("");
            Pyramid.PyramidConstruction(10, true);
            Console.WriteLine("");
            PrimeNumbers.DisplayPrimes();
            int test = Euclide.PgcdRecursive(221, 782);
            Console.WriteLine(test);

            bool test2 = false;
            if (test2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            int test3 = 2 % 2;
            if (test3 == 0)
            {
                Console.WriteLine("Pair");
            }
            else
            {
                Console.WriteLine("Impair");
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
