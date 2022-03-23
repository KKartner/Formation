using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_III
{
    class Program
    {
        static void Main(string[] args)
        {


            //ClassCouncil.SchoolMeans("te.txt", "synthese.txt");

            //long test = SortingPerformance.UseInsertionSort(tableau);
            //Console.WriteLine(test);
            SortingPerformance.DisplayPerformances(new List<int> { 1000, 2000, 5000, 10000 }, 50);
            //Console.WriteLine($"Moyenne Insertion: {test.InsertionMean} Moyenne Quick: {test.QuickMean}");

            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
