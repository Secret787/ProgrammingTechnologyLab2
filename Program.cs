using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTechnologyLab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenNumber generator = new GenNumber();
            int[] Array_sequ = generator.GenNumberArray(10000, Int32.MinValue, Int32.MaxValue);
            //int[] array = generator.GenNumberArray(100, 1, 200);

            int[] Array_parl = (int[])Array_sequ.Clone();
            ParallelBubbleSort Sorter_parl = new ParallelBubbleSort();
            SequentialBubbleSort Sorter_sequ = new SequentialBubbleSort();

            Stopwatch Stopwatch_parl = new Stopwatch();
            Stopwatch Stopwatch_sequ = new Stopwatch();

            Stopwatch_parl.Start();
            Sorter_parl.ParallelBubbleSortBeta(Array_parl);
            Stopwatch_parl.Stop();

            Stopwatch_sequ.Start();
            Sorter_sequ.BubbleSort(Array_sequ);
            Stopwatch_sequ.Stop();

            Console.WriteLine("Паралельная сортировка:");
            //PrintArray(parallelArray);
            Console.WriteLine($"Time: {Stopwatch_parl.ElapsedMilliseconds} ms");

            Console.WriteLine("\nПоследовательная сортировка:");
            //PrintArray(array);
            Console.WriteLine($"Time: {Stopwatch_sequ.ElapsedMilliseconds} ms");

            Console.ReadKey();
        }

        static void PrintArray(int[] array)
        {
            foreach (var item in array)
                Console.Write($"{item} ");
            Console.WriteLine();
        }

    }
}
