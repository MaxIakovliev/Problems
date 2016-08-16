using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Arrays
{
    /// <summary>
    /// http://www.geeksforgeeks.org/kth-smallestlargest-element-unsorted-array/
    /// K’th Smallest/Largest Element in Unsorted Array
    /// </summary>
    class KSmallestElement
    {
        public int SortSolution(int[]a, int k)
        {
            Array.Sort(a);
            return a[k];
        }


    }
}
