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
    }
}
