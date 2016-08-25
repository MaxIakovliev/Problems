using System;
using System.Collections.Generic;
using System.Diagnostics;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Leetcode
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/
    /// </summary>
    public class TwoSum
    {
        /// <summary>
        /// Time Complexity O(n)
        /// Space Complexity O(n)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] Solution1(int[] a, int target)
        {

            var result = new int[2] { -1, -1 };
            var len = a.Length;
            var storage = new Dictionary<int, int>(len);
            unchecked
            {

                for (int i = 0; i < len; i++)
                {
                    if (storage.ContainsKey(a[i]))
                    {
                        result[0] = storage[a[i]];
                        result[1] = i;
                        return result;
                    }
                    else
                    {
                        int tmp = target - a[i];
                        if (!storage.ContainsKey(tmp))
                            storage.Add(tmp, i);
                    }
                }
            }
            return result;
        }
    }
}
