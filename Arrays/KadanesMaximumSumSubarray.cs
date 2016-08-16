using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Arrays
{
    /// <summary>
    /// http://www.geeksforgeeks.org/largest-sum-contiguous-subarray/
    /// In computer science, the maximum subarray problem is the task of finding 
    /// the contiguous subarray within a one-dimensional array of numbers which has the largest sum.
    /// </summary>
    class KadanesMaximumSumSubarray
    {
        public Tuple<int, int, int> Solution(int[] a)
        {
            int max, curMax;
            max = curMax = Int32.MinValue;
            int x = 0, y = 0,
                curX = 0, curY = 0;

            for (int i = 0; i < a.Length; i++)
            {
                
                if(curMax<0)
                {
                    curMax = a[i];
                    curX = i;
                    curY = i;
                }
                else
                {
                    curMax += a[i];
                    curY = i;
                }

                if(curMax>max)
                {
                    max = curMax;
                    x = curX;
                    y = curY;
                }
            }

            return new Tuple<int, int, int>(x, y, max);
        }


        //How to test
        //static void Main(string[] args)
        //{
        //    var arr = new KadanesMaximumSumSubarray();
        //    var a = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        //    var result = arr.Solution(a);
        //    foreach (var item in a)
        //        Console.Write("{0} ", item);
        //    Console.WriteLine();

        //    for (int i = result.Item1; i <= result.Item2; i++)
        //    {
        //        Console.Write("{0} ", a[i]);
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine("max sum={0}", result.Item3);
        //}
    }
}
