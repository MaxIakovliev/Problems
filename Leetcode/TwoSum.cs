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
            bool fakeStep = true;
            for (int i = 0; i < a.Length; )
            {
                int ai = a[i];

                if (fakeStep)
                {
                    ai = Int32.MinValue;
                }

                int tmp = target - ai;
                if (!storage.ContainsKey(tmp))
                    storage.Add(tmp, i);

                if (storage.ContainsKey(tmp) && storage.ContainsKey(ai) && ai == tmp && tmp == 0 && target == 0)
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
                else if (storage.ContainsKey(tmp) && storage.ContainsKey(ai) && ai + tmp == target)
                {
                    if (firstTime)
                        result[0] = storage[tmp];

                    if (result[1] == -1)
                        result[1] = storage[ai];

                    //if(storage[tmp]< result[0])
                    //    result[0] = storage[tmp];


                    firstTime = false;
                    //    if (result[0] != result[1])
                    //        return result;

                }
                if (fakeStep)
                {
                    fakeStep = false;
                }
                else
                    i++;
            }
            return result;
        }
    }
}
