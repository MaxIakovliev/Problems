using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.hackerrank.Strings
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/anagram
    /// </summary>
    public class Anagram
    {
        public void Solution1(List<string> s)
        {
            for (int i = 0; i < s.Count; i++)
            {
                if (s[i].Length % 2 != 0)
                {
                    Console.WriteLine(-1);
                    continue;
                }
                var mid = s[i].Length / 2;
                

                string p = s[i];
                var dict1 = new Dictionary<char, int>();
                var dict2 = new Dictionary<char, int>();

                for (int j = 0; j < p.Length; j++)
                {
                    if (j < mid)
                    {
                        if (!dict1.ContainsKey(p[j]))
                            dict1.Add(p[j], 1);
                        else
                            dict1[p[j]] = dict1[p[j]] + 1;
                    }
                    else if (j >= mid)
                    {
                        if (!dict2.ContainsKey(p[j]))
                            dict2.Add(p[j], 1);
                        else
                            dict2[p[j]] = dict2[p[j]] + 1;
                    }
                }
                int count = 0;
                foreach (var d2 in dict2)
                {
                    if (!dict1.ContainsKey(d2.Key))
                        count = count + d2.Value;
                    else
                    {
                        if (dict1[d2.Key] < d2.Value)
                            count = count + (d2.Value - dict1[d2.Key]);

                    }
                }
                Console.WriteLine(count);
            }
        }
    }
}
