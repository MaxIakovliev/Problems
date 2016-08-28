using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Leetcode
{
    /// <summary>
    /// https://leetcode.com/problems/longest-substring-without-repeating-characters/
    /// </summary>
    public class LongestSubstringWithoutRepeatingCharacters
    {
        /// <summary>
        /// Works correctly, but not matched time limitations.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int Solution1(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            var current = new Dictionary<char, int>();
            int start = 0, end = 0, maxStart = 0, maxEnd = 0, len = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (current.ContainsKey(s[i]))
                {
                    len = end - start;
                    if (len > (maxEnd - maxStart))
                    {
                        maxStart = start;
                        maxEnd = end;
                    }
                    start = current[s[i]] + 1;
                    for (int k = current[s[i]]; k >= 0; k--)
                    {
                        if (current.ContainsValue(k))
                            current.Remove(s[k]);
                    }
                }
                end = i;
                current.Add(s[i], i);
            }

            len = end - start;
            if (len > (maxEnd - maxStart))
            {
                maxStart = start;
                maxEnd = end;
            }

            Console.WriteLine(s.Substring(maxStart, maxEnd + 1 - maxStart));

            return maxEnd + 1 - maxStart;
        }



        public int Solution2(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            var current = new Dictionary<char, int>();
            int start = 0, end = 0, maxStart = 0, maxEnd = 0, len = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (current.ContainsKey(s[i]))
                {
                    len = end - start;
                    if (len > (maxEnd - maxStart))
                    {
                        maxStart = start;
                        maxEnd = end;
                    }
                    start = current[s[i]] + 1;
                    i = start;
                    current.Clear();

                }
                end = i;
                current.Add(s[i], i);
            }

            len = end - start;
            if (len > (maxEnd - maxStart))
            {
                maxStart = start;
                maxEnd = end;
            }

            Console.WriteLine(s.Substring(maxStart, maxEnd + 1 - maxStart));

            return maxEnd + 1 - maxStart;
        }


        /// <summary>
        /// most optimized solution
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int Solution3(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            var current = new Dictionary<char, int>();
            int start = 0, end = 0, maxStart = 0, maxEnd = 0, len = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (current.ContainsKey(s[i]) && current[s[i]] >= start)
                {
                    len = end - start;
                    if (len > (maxEnd - maxStart))
                    {
                        maxStart = start;
                        maxEnd = end;
                    }
                    start = current[s[i]] + 1;
                }
                end = i;
                if (current.ContainsKey(s[i]))
                    current[s[i]] = i;
                else
                    current.Add(s[i], i);
            }

            len = end - start;
            if (len > (maxEnd - maxStart))
            {
                maxStart = start;
                maxEnd = end;
            }

            Console.WriteLine(s.Substring(maxStart, maxEnd + 1 - maxStart));

            return maxEnd + 1 - maxStart;
        }
    }
}
