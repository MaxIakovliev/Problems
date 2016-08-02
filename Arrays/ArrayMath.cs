using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Arrays
{
    class ArrayMath
    {
        public int[] Add(int[] a, int[] b)
        {
            int s = Math.Max(a.Length, b.Length);
            var result = new int[s];
            int i, j;
            i = a.Length - 1;
            j = b.Length - 1;
            int k = 0;
            while (i >= 0 || j >= 0)
            {
                int sum = a[i--] + b[j--];
                result[--s] = (sum + k) > 9 ? (sum + k) % 10 : (sum + k);

                if ((sum + k) > 9)
                    k = 1;
                else
                    k = 0;

            }
            while (i >= 0)
            {
                result[s--] = a[i--] + k;
                k = 0;
            }

            while (j >= 0)
            {
                result[s--] = b[j--] + k;
                k = 0;
            }

            if (k > 0)
            {
                Array.Resize(ref result, result.Length + 1);
                for (int d = result.Length - 2; d >= 0; d--)
                {
                    result[d + 1] = result[d];
                }
                result[0] = k;
            }

            return result;
        }
    }
}
