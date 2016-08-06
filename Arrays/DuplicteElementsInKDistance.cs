using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Arrays
{
    /// <summary>
    /// http://www.geeksforgeeks.org/check-given-array-contains-duplicate-elements-within-k-distance/
    /// </summary>
    class DuplicteElementsInKDistance
    {
        public HashSet<int> Solution1(int[] a, int dist)
        {

            var indexes = new Dictionary<int, int>();
            var result = new HashSet<int>();
            indexes.Add(a[0], 0);
            for (int i = 1; i < a.Length; i++)
            {
                if (!indexes.ContainsKey(a[i]))
                {
                    indexes.Add(a[i], i);
                }
                else
                {
                    int tmp = i - indexes[a[i]];
                    if (tmp >= dist && tmp > indexes[a[i]])
                        result.Add(a[i]);
                }
            }
            return result;
        }
    }
}
