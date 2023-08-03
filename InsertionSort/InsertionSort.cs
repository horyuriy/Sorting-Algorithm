using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class InsertionSort
    {
        public static void Swap(ref int firstElem, ref int secondElem)
        {
            var temp = firstElem;
            firstElem = secondElem;
            secondElem = temp;
        }
        public static int[] InsertionSorts(int[] array)
        {
            for(var i=1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j-1] > key))
                {
                    Swap(ref array[j-1],ref array[j]);
                    j--;
                }
                array[j] = key;
            }
            return array;
        }
    }
}
