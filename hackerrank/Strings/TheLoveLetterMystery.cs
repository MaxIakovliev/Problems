using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.hackerrank.Strings
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/the-love-letter-mystery
    /// </summary>
    class TheLoveLetterMystery
    {
        public List<int> Solution1(List<string> s)
        {
            var abc = "abcdefghijklmnopqrstuvwxyz";
            var dict = new Dictionary<char, int>();
            for (int i = 0; i < abc.Length; i++)
                dict.Add(abc[i], i);

            var result = new List<int>();
            for(int i=0; i<s.Count; i++)
            {
                var p=s[i];
                int start = 0, end = p.Length-1;
                int diff = 0;
                while(start<end)
                {
                    if (start < p.Length-1 && end > 0)
                    {
                        diff += Math.Abs(dict[p[start]] - dict[p[end]]);
                        start++;
                        end--;
                    }
                }
                Console.WriteLine(diff);
                result.Add(diff);
            }
            return result;
        }
    }
}
