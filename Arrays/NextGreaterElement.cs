using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Arrays
{
    /// <summary>
    /// http://www.geeksforgeeks.org/next-greater-element/
    /// Next Greater Element
    /// Given an array, print the Next Greater Element (NGE)
    /// for every element. The Next greater Element for an element x is the first greater element on 
    /// the right side of x in array. Elements for which no greater element exist, consider next greater element as -1.
    /// </summary>
    class NextGreaterElement
    {
        public Tuple<int, int>[] Solution1(int[] a)
        {
            var result = new Tuple<int, int>[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                int curr = a[i];
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (curr < a[j])
                    {
                        result[i] = new Tuple<int, int>(a[i], a[j]);
                        break;
                    }
                }
                if (result[i] == null)
                    result[i] = new Tuple<int, int>(a[i], -1);

            }
            if (result[result.Length-1] == null)
                result[result.Length - 1] = new Tuple<int, int>(a[a.Length - 1], -1);
            return result;
        }
    }
}
