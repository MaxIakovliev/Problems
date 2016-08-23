using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Leetcode
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/
    /// </summary>
    class TwoSum
    {
        /// <summary>
        /// Time Complexity O(n)
        /// Space Complexity O(n)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] Solution1(int [] a, int target)
        {
            var result = new int[2];
            var storage = new Dictionary<int,int>();

            for(int i=0; i<a.Length; i++)
            {
                int tmp = target - a[i];
                    storage.Add(tmp, i);
                if (storage.ContainsKey(tmp) && storage.ContainsKey(a[i]))
                {
                    result[0] = storage[tmp];
                    result[1] = storage[a[i]];
                    return result;
                }
            }
            return result;
        }
    }
}
