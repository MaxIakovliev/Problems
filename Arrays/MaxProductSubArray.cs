using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Arrays
{
    /// <summary>
    /// Maximum Product Subarray
    /// https://leetcode.com/problems/maximum-product-subarray/
    /// Find the contiguous subarray within an array (containing at least one number) which has the largest product.
    /// </summary>
    class MaxProductSubArray
    {
        /// <summary>
        /// Rough Solution. It can be done better
        /// 1. walk through  input array.
        /// 2. Calculate max products for subarrays
        /// 3. Save max products and indexes of sub array into temp storage
        /// 4. Fetch max product from temp storage
        /// Time Complexity O(n)
        /// Space Complexity O(k)
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int[] Solution1(int[] a)
        {
            if (a.Length == 0)
                throw new Exception("array is empty");
            int[] result = null;
            int superMax = a[0];
            int prevMax = a[0];
            int start, end;
            start = end = 0;
            bool needFlush = true;
            var subProducts = new List<Tuple<int, int, int>>();
            for (int i = 1; i < a.Length; i++)
            {
                int tmp = prevMax * a[i];
                if (tmp > superMax)
                    superMax = tmp;

                if (tmp >= prevMax)
                {
                    end = i;
                    prevMax = tmp;
                    needFlush = true;
                }
                else
                {
                    if (prevMax >= superMax)
                        subProducts.Add(new Tuple<int, int, int>(start, end, prevMax));
                    prevMax = a[i];
                    start = i;
                    end = i;
                    needFlush = false;
                }
            }
            if (needFlush)
            {
                subProducts.Add(new Tuple<int, int, int>(start, end, prevMax));
            }
            if (subProducts.Count == 0)
                return a;

            prevMax = subProducts[0].Item3;
            start = 0;
            for (int i = 0; i < subProducts.Count; i++)
            {
                if (subProducts[i].Item3 > prevMax)
                {
                    prevMax = subProducts[i].Item3;
                    start = i;
                }
            }

            if (subProducts[start].Item1 == subProducts[start].Item2)
                result = new int[] { subProducts[start].Item1 };
            else
                result = new int[subProducts[start].Item2 - subProducts[start].Item1 + 1];

            int j = 0;
            for (int i = subProducts[start].Item1; i <= subProducts[start].Item2; i++)
            {
                result[j] = a[i];
                j++;
            }

            Console.WriteLine("debug info- SubProducts size:{0}", subProducts.Count);
            return result;
        }


        //How to use
        //static void Main(string[] args)
        //{
        //    var arr = new MaxProductSubArray();
        //    var data = new int[] { 2, 3, -2, 8, 200, -1, 12, 15 };
        //    var result = arr.Solution1(data);

        //    foreach (var item in result)
        //        Console.Write(" {0}", item);

        //    Console.WriteLine();
        //}
    }
}
