using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Leetcode
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public string Solution1(string s)
        {
            var current = new HashSet<char>();
            int start = 0, end = 0, maxStart=0, maxEnd=0;
            for(int i=0; i<s.Length; i++)
            {
                if(current.Contains(s[i]))
                {
                    current.Clear();
                    var len = end - start;
                    if(len>(maxStart-maxEnd))
                    {
                        maxStart = start;
                        maxEnd = end;
                    }
                    start = i;
                    end = i;
                }
                current.Add(s[i]);
                end = i;
            }
            return s.Substring(start, end - start);
        }
    }
}
