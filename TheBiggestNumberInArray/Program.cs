using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBiggestNumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 54, 9, 7843, 234, 890, 65192, 31, 112847 };

            int maxValue = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                    maxValue = array[i];
            }

            Console.WriteLine(maxValue);

        }
    }
}
