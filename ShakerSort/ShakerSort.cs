using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShakerSort
{
    public class ShakerSort
    {
        public static void Swap(ref int firstElem, ref int secondElem)
        {
            var temp = firstElem;
            firstElem = secondElem;
            secondElem = temp;
        }

        public static int[] ShakerSorts(int[] array)
        {
            for (var i = 0; i < array.Length / 2; i++)
            {
                var swapFlag = false;

                for (var j = i; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        swapFlag = true;
                    }
                }

                for (var j = array.Length - 2 - i; j > i; j--)
                {

                    if (array[j - 1] > array[j])
                    {
                        Swap(ref array[j - 1], ref array[j]);
                        swapFlag = true;
                    }
                   
                }
                if (!swapFlag)
                {
                    break;
                }
            }
            return array;
        }

    }
}
