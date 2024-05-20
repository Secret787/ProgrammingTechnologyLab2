using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTechnologyLab2
{
    public class ParallelBubbleSort
    {
        public void ParallelBubbleSortBeta(int[] array)
        {
            int Cores = 2;
            Action[] actions = new Action[Cores];
            actions[0] = () => BubbleSort(array, 1);
            actions[1] = () => BubbleSort(array, 2);
            Parallel.Invoke(actions);

        }

        private void BubbleSort(int[] array, int step)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % step == 0)
                    swap(array, step, 0);
                else
                    swap(array, step, 1);
               
            }
        }
        private void swap(int[] array, int step, int start)
        {
            for (int j = start; j < array.Length - 1; j += 2)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }

    }

}
