using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    class Program
    {
        static void Main(string[] args)
        {


            // Keep the console window open
            Console.WriteLine("----------------------");
            int[] array1 = new int[] { 1, -5, 10, 3, 0, 4, 2, -7 };
            Search.LinearSearch(array1, 2);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
