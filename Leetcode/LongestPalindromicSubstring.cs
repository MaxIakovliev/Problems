using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Leetcode
{
    /// <summary>
    /// https://leetcode.com/problems/longest-palindromic-substring/
    /// </summary>
    public class LongestPalindromicSubstring
    {
        public string Solution1(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            if (s.Length == 1)
                return s;
            if (s.Length == 2 && char.ToUpperInvariant(s[0]) == char.ToUpperInvariant(s[1]))
                return s;
            int start = 0, end = 0, maxStart = 0, maxEnd = 0;
            for (int i = 1; i < s.Length; i++)
            {
                GetPalindrome2(s, i, out start, out end);
                if (start < 0 || end < 0) continue;
                var len = end - start;
                if (len > (maxEnd - maxStart))
                {
                    maxStart = start;
                    maxEnd = end;
                }
            }

            return s.Substring(maxStart, maxEnd + 1 - maxStart);
        }
  
        /// <summary>
        /// check if string of palindrome by searching of 4 possiblec cases 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="idx"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        private void GetPalindrome2(string s, int idx, out int start, out int end)
        {
            start = end = -1;
            bool valid = true;
            int i = 1;
            bool case1 = false, case2 = false, case3 = false, case4 = false;
            do
            {
                if ((idx - i) >= 0 && idx + i < s.Length - 1 &&
                   idx + i + 1 < s.Length && char.ToUpperInvariant(s[idx]) == char.ToUpperInvariant(s[idx + 1])
                       && char.ToUpperInvariant(s[idx - i]) == char.ToUpperInvariant(s[idx + i + 1])
                   && !case1 && !case3 && !case4
                   )
                {
                    start = idx - i;
                    end = idx + i + 1;
                    i++;
                    case2 = true;
                } 
                else
                if ((idx - i) >= 0 && idx + i < s.Length &&
                    (
                        (char.ToUpperInvariant(s[idx - i]) == char.ToUpperInvariant(s[idx + i]))
                    ) && !case2 && !case3 && !case4
                   )
                {
                    start = idx - i;
                    end = idx + i;
                    i++;
                    case1 = true;
                }

                else if (idx + i < s.Length &&
                    (
                        (char.ToUpperInvariant(s[idx]) == char.ToUpperInvariant(s[idx + i]))
                    && !case1 && !case2 && !case4
                    )
                   )
                {
                    start = idx;
                    end = idx + i;
                    i++;
                    case3 = true;
                }
                else if ((idx - i) >= 0 &&
                (
                    (char.ToUpperInvariant(s[idx - i]) == char.ToUpperInvariant(s[idx]))
                && !case1 && !case2 && !case3
                )
               )
                {
                    start = idx - i;
                    end = idx;
                    i++;
                    case4 = true;
                }
                else
                    valid = false;
            } while (valid);
        }
    }
}
