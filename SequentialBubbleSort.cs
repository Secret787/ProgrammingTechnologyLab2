using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTechnologyLab2
{
    public class SequentialBubbleSort // сортировка пузырьком
    { 
        public void BubbleSort(int[] array)
        {
            int length = array.Length;  
            int temp;

            for (int i = 0; i < length - 1; i++) 
            {
                for (int j = 0; j < length - i - 1; j++) 
                { 
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }


    }
}
