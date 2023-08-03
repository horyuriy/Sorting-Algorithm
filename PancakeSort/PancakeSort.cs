using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PancakeSort
{
    public class PancakeSort
    {
        public static int IndexOfMax(int[] array, int n)
        {
            int result = 0;
            for (var i = 1; i <= n; ++i)
            {
                if (array[i] > array[result])
                {
                    result = i;
                }
            }
            return result;
        }
        public static void Flip(int[] array, int end)
        {
            for (var start = 0; start < end; start++, end--)
            {
                var temp = array[start]; array[start] = array[end]; array[end] = temp;

            }
        }
        public static int[] PancakeSorts(int[] array)
        {
            for (var subArrayLength = array.Length-1; subArrayLength >= 0; subArrayLength--)
            {
                var indexOfMax=IndexOfMax(array,subArrayLength);
                if(indexOfMax!= subArrayLength)
                {
                    Flip(array, indexOfMax);
                    Flip(array, subArrayLength);
                }
            }
            return array;
        }
    }
}
