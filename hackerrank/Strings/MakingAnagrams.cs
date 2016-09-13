using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.hackerrank.Strings
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/making-anagrams
    /// </summary>
    class MakingAnagrams
    {
        public void Solution1(List<string> s)
        {
            var d1 = new Dictionary<char, int>();
            var d2 = new Dictionary<char, int>();

            var p = s[0];

            for (int i = 0; i < s[0].Length; i++)
            {
                if (!d1.ContainsKey(p[i]))
                    d1.Add(p[i], 1);
                else
                    d1[p[i]] = d1[p[i]] + 1;
            }

            p = s[1];

            for (int i = 0; i < s[1].Length; i++)
            {

                if (!d2.ContainsKey(p[i]))
                    d2.Add(p[i], 1);
                else
                    d2[p[i]] = d2[p[i]] + 1;
            }

            int count = 0;
            foreach (var i in d1)
            {
                if (!d2.ContainsKey(i.Key))
                    count += i.Value;
            }

            foreach (var i in d2)
            {
                if (!d1.ContainsKey(i.Key))
                    count += i.Value;
                else
                {
                    var diff = Math.Abs(i.Value - d1[i.Key]);
                    count += diff;
                }
            }

            Console.WriteLine(count);


        }
    }
}
