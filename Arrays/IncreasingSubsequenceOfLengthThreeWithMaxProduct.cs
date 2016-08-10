using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Arrays
{
    /// <summary>
    /// http://www.geeksforgeeks.org/increasing-subsequence-of-length-three-with-maximum-product/
    /// Given a sequence of non-negative integers, find the subsequence of length 3 having 
    /// maximum product with the numbers of the subsequence being in ascending order.
    /// </summary>
    class IncreasingSubsequenceOfLengthThreeWithMaxProduct
    {
        public void Solution1(int[] a)
        {
            var left = new int[a.Length];
            var right = new int[a.Length];
            int max = Int32.MinValue;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                if (max < a[i])
                {
                    max = a[i];
                    right[i] = -1;
                }
                else
                    right[i] = max;
            }

            var st = new Stack<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (right[i] == -1)
                {
                    left[i] = -1;
                    continue;
                }
                max = -1;
                while (st.Count != 0 && st.Peek() < a[i])
                {
                    max = st.Pop();

                }
                left[i] = max;
                st.Push(a[i]);
            }

            max = Int32.MinValue;
            int ai, aj, ak;
            ai = aj = ak = 0;
            for (int i = 1; i < a.Length - 1; i++)
            {
                if (max < left[i] * a[i] * right[i])
                {
                    max = left[i] * a[i] * right[i];
                    ai = left[i];
                    aj = a[i];
                    ak = right[i];
                }
            }

            Console.WriteLine("max={0}", max);
            Console.WriteLine("{0}, {1}, {2}", ai, aj, ak);
        }
    }
}
