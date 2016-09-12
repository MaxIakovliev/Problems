using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.hackerrank.Strings
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/two-strings
    /// </summary>
    class TwoStrings
    {
        public void Solution1(Tuple<string, string> t)
        {
            var d1 = new HashSet<char>();
            var d2 = new HashSet<char>();
            for (int i = 0; i < t.Item1.Length; i++)
            {
                if (!d1.Contains(t.Item1[i]))
                    d1.Add(t.Item1[i]);
            }
            for (int i = 0; i < t.Item2.Length; i++)
            {
                if (!d2.Contains(t.Item2[i]))
                    d2.Add(t.Item2[i]);
            }

            bool found = false;
            foreach (var i in d1)
            {
                if (d2.Contains(i))
                {
                    Console.WriteLine("YES");
                    found = true;
                    break;
                }
            }
            if (!found)
                Console.WriteLine("NO");
        }
    }
}
