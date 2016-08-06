using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Arrays
{
    /// <summary>
    /// http://www.geeksforgeeks.org/given-an-array-of-of-size-n-finds-all-the-elements-that-appear-more-than-nk-times/
    /// </summary>
    class FindAllElementsOccurringMoreThanNbyKTimes
    {
        /// <summary>
        /// Create additional dictionary for storing elements respective occurrence
        /// Walk through all array and save results into additional array
        /// Walk through additional array and remove  all values less than n/k
        /// Time complexity O(n*n)
        /// Space complexity O(k)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public Dictionary<int, int> Solution1(int[] a, int n)
        {
            var result = new Dictionary<int, int>();
            int i = 0;
            for (i = 0; i < a.Length; i++)
                result[a[i]]++;
            int nk = n / a.Length;

            i = 0;
            for (i = 0; i < a.Length; i++)
            {
                if (result[a[i]] < nk)
                    result.Remove(a[i]);
            }
            return result;
        }

        /// <summary>
        /// Sort input array
        /// walk array sequentlially,
        /// save to output ellemnets the occurr more than n/k time
        /// Time Compexity O(n log n)
        /// Speca Complexity O(k)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public List<int> Solution2(int[] a, int n)
        {
            var result = new List<int>();
            Array.Sort(a);
            int nk = a.Length / n;
            int prev = a[0];
            int occr = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if(a[i]!=prev)
                {
                    if(occr>nk)
                    {
                        result.Add(prev);
                    }
                    occr = 0;
                }
                else
                {
                    occr++;
                }
                a[i] = prev;
            }
            return result;
        }
    }
}
