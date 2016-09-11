using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.hackerrank.Strings
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/string-construction
    /// </summary>
    class StringConstruction
    {
        public void Solution1(List<string> arr)
        {
            for(int i=0; i<arr.Count; i++)
            {
                var dict = new HashSet<char>();

                for(int j=0; j<arr[i].Length; j++)
                {
                    if (!dict.Contains(arr[i][j]))
                        dict.Add(arr[i][j]);
                }
                Console.WriteLine(dict.Count);
            }
        }
    }
}
