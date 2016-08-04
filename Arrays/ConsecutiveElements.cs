using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Arrays
{
    /// <summary>
    /// problem: http://www.geeksforgeeks.org/check-if-array-elements-are-consecutive/
    /// </summary>
    class ConsecutiveElements
    {
        /// <summary>
        /// Check if Array Elements are Consecutive
        /// Time Complexity O(n log n)
        /// Space Complexity (1)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="allowDuplications"></param>
        /// <returns>true/false</returns>
        public bool AreConsecutiveSolution1(int[] a, bool allowDuplications=false)
        {
            Array.Sort(a);
            for(int i=1; i<a.Length; i++)
            {
                if (allowDuplications)
                {
                    if (a[i] != a[i - 1] || Math.Abs(a[i]) - Math.Abs(a[i - 1]) != Math.Abs(1))
                        return false;
                }
                else
                {
                    if (Math.Abs(a[i]) - Math.Abs(a[i - 1]) != Math.Abs(1))
                        return false;
                }
            }
            return true;
        }
    }
}
