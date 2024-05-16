using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTechnologyLab2
{
    internal class BugParallelBubbleSort
    {
        public void ParallelBubbleSort(int[] array)
        {
            int n = array.Length;
            Parallel.For(0, n - 1, i =>
             {
                 for (int j = 0; j < n - i - 1; j++)
                 {
                     if (array[j] > array[j + 1])
                     {
                         int temp = array[j];
                         array[j] = array[j + 1];
                         array[j + 1] = temp;
                     }
                 }
             });
         }

    }
}
