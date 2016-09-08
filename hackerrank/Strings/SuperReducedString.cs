using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.hackerrank.Strings
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/reduced-string
    /// </summary>
    public class SuperReducedString
    {
        public string Solution1(string s)
        {

            if (string.IsNullOrWhiteSpace(s)) return "Empty String";
            if (s.Length == 1) return s;

            var sb = new StringBuilder(s);
            char? prev = sb[0];
            int count = 1, idx = 1;

            var isRemoved = false;
            while (true)
            {
               
                if (sb[idx] == prev)
                {
                    count++;
                    idx++;
                }
                else
                {
                    prev = sb[idx];
                    count = 1;
                    idx++;
                }

                if (count == 2)
                {
                    sb.Remove(idx - 2, 2);
                    if (sb.Length == 0) break;
                    idx = 0;
                    prev = sb[idx];
                    idx++;
                    isRemoved = true;
                
                }
                if (idx > sb.Length - 1 && !isRemoved)
                    break;

                if (idx > sb.Length - 1)
                {
                    idx = 0;
                    prev = sb[idx];
                    idx++;
                    count = 1;
                    isRemoved = false;
                }
                
            }
            return sb.ToString() == "" ? "Empty String" : sb.ToString();
        }
    }
}
