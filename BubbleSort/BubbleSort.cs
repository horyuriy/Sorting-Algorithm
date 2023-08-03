using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class BubbleSort
    {
        public static void Swap(ref int firstElem, ref int SecondElem)
        {
            var temp = firstElem;
            firstElem = SecondElem;
            SecondElem = temp;
        }
        public static int[] BubbleSorts(int[] array)
        {
            var length = array.Length;
            for (var i = 1; i < length; i++)
            {
                for (var j = 0; j < length - 1; j++)
                {
                    if (array[i] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
            return array;
        }
    }
}
