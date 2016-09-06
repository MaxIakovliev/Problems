using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Leetcode
{
    public class StrStrImplementation
    {
        /// <summary>
        /// custom implementation   "IndexOf" function
        /// </summary>
        /// <param name="s"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public int StrStr(string s, string q)
        {
            if (  string.IsNullOrEmpty(q) ) return 0;
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(q) || s.Length < q.Length) return -1;

            int idx = 0;
            int start = 0;
            int end = 0;
            while (idx+q.Length-1 < s.Length)
            {
                if (s[idx+q.Length-1] == q[q.Length-1])
                {
                    start = idx;
                    end = idx + q.Length - 1;
                    while (start <= end && end <= s.Length)
                    {
                        if (s[start] == q[start - idx] && s[end] == q[end - idx])
                        {
                            if (start == end) return idx;
                            start++;
                            end--;
                            if (start > end) return idx;
                        }
                        else
                        {
                            idx = start;
                            break;
                        }
                    }
                }
                else
                    idx++;// =idx+ q.Length;
            }
            return -1;
        }
    }
}
