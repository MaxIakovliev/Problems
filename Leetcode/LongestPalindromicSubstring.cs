using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Leetcode
{
    public class LongestPalindromicSubstring
    {
        public string Solution1(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            if (s.Length == 1)
                return s;
            int start = 0, end = 0, maxStart = 0, maxEnd = 0;
            for(int i=1; i<s.Length; i++)
            {
                GetPalindrome(s, i, out start, out end);
                if (start < 0 || end < 0) continue;
                var len = end - start;
                if(len>(maxEnd-maxStart))
                {
                    maxStart = start;
                    maxEnd = end;
                }
            }
            Console.WriteLine(s.Substring(maxStart, maxEnd + 1 - maxStart));

            return s.Substring(maxStart, maxEnd + 1 - maxStart);
        }

        private void GetPalindrome(string s, int idx, out int start, out int end)
        {
            start = end = -1;
            bool valid=true;
            int i = 1;
            do
            {
                if ((idx - i) >= 0 && s[idx - i] == s[idx + i] && idx + i < s.Length)
                {
                    start = idx - 1;
                    end = idx + i;
                    i++;
                }
                else
                    valid = false;
            } while (valid);
        }
    }
}
