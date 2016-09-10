using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.hackerrank.Strings
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/gem-stones
    /// </summary>
    class Gemstones
    {
        public int Solution1(List<string>s)
        {
            List<Task<HashSet<char>>> t = new List<Task<HashSet<char>>>();
            for(int i=0; i<s.Count(); i++)
            {
                if (string.IsNullOrEmpty(s[i]))
                    return 0;
                string input = s[i];
                t.Add(Task.Factory.StartNew<HashSet<char>>(() => {
                    var res = new HashSet<char>();
                    for(int j=0; j<input.Length; j++)
                    {
                        if (!res.Contains(input[j]))
                            res.Add(input[j]);
                    }
                    return res;
                }));
            }

            int result = 0;
            Task.WaitAll(t.ToArray());

            if (s.Count() == 1)
                return t[0].Result.Count();

            foreach (var item in t[0].Result)
            {

                bool exist = true;
                for (int j = 1; j < t.Count(); j++)
                {
                    if(!t[j].Result.Contains(item))
                    {
                        exist = false;
                        break;
                    }
                }
                if (exist)
                    result++;
            }
                return result;
        }
    }
}
