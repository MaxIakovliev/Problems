using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.BinarySearch
{
    /// <summary>
    /// https://www.careercup.com/question?id=4798365246160896
    /// Example : Given the AP :- 1 3 7 9 11 13 find the missing value "which would be 5 here". 
    /// Conditions : Get an user for the length of AP sequence and make sure user provides length is above 3. 
    /// Get the input in a single line ex:- "1 3 5 7 9 11" 
    /// Provide the solution in O(n) or less if you can.
    /// </summary>
    class ArithmeticProgressionSearch
    {
        public int Solution(int[] a)
        {
            int low = 0, high = a.Length - 1,
                ap = (a[a.Length - 1] - a[0]) / a.Length,
                middle = 0;
            while (low <= high)
            {
                middle = (low + high) / 2;
                if (a[middle] == a[0] + middle * ap)
                    low = middle + 1;
                else if (a[middle] > a[0] + middle * ap &&
                    a[middle - 1] == a[0] + (middle - 1) * ap)
                    return a[0] + middle * ap;
                else
                    high = middle - 1;
            }
            return -1;
        }
    }
}
