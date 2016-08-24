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
            var storage = new Dictionary<int, int>();
            bool firstTime = true;
            for (int i = 0; i < a.Length; i++)
            {

                int tmp = target - a[i];
                if (!storage.ContainsKey(tmp))
                    storage.Add(tmp, i);

                if (storage.ContainsKey(tmp) && storage.ContainsKey(a[i]) && a[i] == tmp && tmp == 0 && target == 0)
                {
                    if (firstTime)
                        result[0] = i;
                    else
                    {
                        result[1] = i;
                        return result;
                    }
                    firstTime = false;
                }
                else if (storage.ContainsKey(tmp) && storage.ContainsKey(a[i]) && a[i] + tmp == target)
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
