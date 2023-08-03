using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
    public class ShellSort
    {
        static void Swap(ref int firstElem, ref int secondElem)
        {
            var temp = firstElem;
            firstElem = secondElem;
            secondElem = temp;
        }
        public static int[] ShellSorts(int[] array)
        {
            var d = array.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < array.Length; i++)
                {
                    var j = 1;
                    while ((j >= d) && (array[j - d] > array[j]))
                    {
                        Swap(ref array[j], ref array[j - d]);
                        j = j - d;
                    }
                }
                d = d / 2;
            }
            return array;
        }
    }
}
