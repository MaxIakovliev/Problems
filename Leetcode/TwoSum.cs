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

        //How to test, or you can run unit test
        //static void Main(string[] args)
        //{
        //    var p = new TwoSum();
        //    var input = new int[] { 4, 0, 8, 6, 9 };//0,4,0,90 };//2, 7, 11, 15};
        //    int target = 8;
        //    var result = p.Solution1(input, target);//0); //9);
        //    Console.WriteLine("{0}, {1}; {2},{3},", result[0], result[1], input[result[0]], input[result[1]]);
        //    Console.WriteLine(input[result[0]] + input[result[1]] == target);
        //}
    }
}
