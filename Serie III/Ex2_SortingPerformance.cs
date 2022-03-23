using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_III
{
    public struct SortData
    {
        public SortData(long insertionMean, long insertionStd, long quickMean, long quickStd)
        {
            InsertionMean = insertionMean;
            InsertionStd = insertionStd;
            QuickMean = quickMean;
            QuickStd = quickStd;
        }

        /// <summary>
        /// Moyenne pour le tri par insertion
        /// </summary>
        public long InsertionMean { get; set; }
        /// <summary>
        /// Écart-type pour le tri par insertion
        /// </summary>
        public long InsertionStd { get; set; }
        /// <summary>
        /// Moyenne pour le tri rapide
        /// </summary>
        public long QuickMean { get; set; }
        /// <summary>
        /// Écart-type pour le tri rapide
        /// </summary>
        public long QuickStd { get; set; }
    }

    public static class SortingPerformance
    {
        public static void DisplayPerformances(List<int> sizes, int count)
        {
            List<SortData> datas = PerformancesTest(sizes, count);
            Console.WriteLine("n;MeanInsertion;StdInsertion;MeanQuick;StdQuick");
            for (int i = 0; i < datas.Count; i++)
            {
                Console.WriteLine($"{sizes[i]};{datas[i].InsertionMean};{datas[i].InsertionStd};{datas[i].QuickMean};{datas[i].QuickStd}");
            }
        }

        public static List<SortData> PerformancesTest(List<int> sizes, int count)
        {
            List<SortData> mesListes = new List<SortData>();
            for (int i = 0; i < sizes.Count; i++)
            {
                SortData test = PerformanceTest(sizes[i], count);
                mesListes.Add(test);
            }
            return mesListes;
        }

        public static SortData PerformanceTest(int size, int count)
        {
            long quickSomme = 0;
            long longSomme = 0;
            for (int i = 0; i < count; i++)
            {
                List<int[]> maListe = ArraysGenerator(size);
                long test1 = UseQuickSort(maListe[0]);
                quickSomme += test1;
                long test2 = UseInsertionSort(maListe[1]);
                longSomme += test2;
            }
            long quickMoyenne = quickSomme / count;
            long longMoyenne = longSomme / count;
            long quickStd = ;//TODO
            long insertStd = ;//TODO

            SortData perf = new SortData(longMoyenne, insertStd, quickMoyenne, quickStd);
            return perf;
        }

        private static List<int[]> ArraysGenerator(int size)
        {
            int[] tableau1 = new int[size];
            int[] tableau2 = new int[size];
            List<int[]> maListe = new List<int[]>();
            var rand = new Random();

            for (int i = 0; i < tableau1.Length; i++)
            {
                int tmp = rand.Next(-1000, 1001);
                tableau1[i] = tmp;
                tableau2[i] = tmp;
            }
            maListe.Add(tableau1);
            maListe.Add(tableau2);
            return maListe;
        }

        public static long UseInsertionSort(int[] array)
        {
            Stopwatch s = Stopwatch.StartNew();
            InsertionSort(array);
            s.Stop();
            long tempsBrut = s.ElapsedMilliseconds;
            return tempsBrut;
        }

        public static long UseQuickSort(int[] array)
        {
            Stopwatch s = Stopwatch.StartNew();
            QuickSort(array, 0, array.Length - 1);
            s.Stop();
            long tempsBrut = s.ElapsedMilliseconds;
            return tempsBrut;
        }

        private static void InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        int tmp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = tmp;
                    }
                }
            };
        }

        private static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);
                QuickSort(array, left, pivot - 1);
                QuickSort(array, pivot + 1, right);
            }
        }

        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left;
            for (int j = left; j < right; j++)
            {
                if (array[j] < pivot)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                }
            }
            int tmp = array[i];
            array[i] = array[right];
            array[right] = tmp;
            return i;
        }
    }
}
