using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.hackerrank.Strings
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/alternating-characters
    /// </summary>
    public class AlternatingCharacters
    {
        public int Solution1(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            var sb = new StringBuilder(s);
            var a = s[0];
            int count = 1;
            var x = true;
            int res=0;
            while(count<s.Length)
            {
                if(x)
                {
                    while (count<sb.Length && a == sb[count])
                    {
                        //sb.Remove(count, 1);
                        res++;
                        count++;
                    }
                }
                else
                {
                    while(count<sb.Length&& a!=sb[count])
                    {
                        //sb.Remove(count, 1);
                        res++;
                        count++;
                    }
                }
                x ^= true;
                count++;
            }
            return res;
        }
    }
}
