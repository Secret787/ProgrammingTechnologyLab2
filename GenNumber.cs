using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTechnologyLab2
{
    public class GenNumber
    {
        private Random random;

        public GenNumber()
        {
            random = new Random();
        }

        public int[]  GenNumberArray(int length, int minvalue, int maxvalue)
        {
            int[] array = new int[length];
            for (int i = 0; i < length; i++) 
                array[i] = random.Next(minvalue,maxvalue);

            return array;
        }
    }
}
