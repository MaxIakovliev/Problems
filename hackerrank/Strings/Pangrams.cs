using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.hackerrank.Strings
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/pangrams
    /// </summary>
    public class Pangrams
    {
        public string Solution1(string s)
        {
            
            s = s.ToLower();
            var h = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]) && !h.Contains(s[i]))
                {
                    h.Add(s[i]);
                }
            }
            if (h.Count == 26)
                return "pangram";
            else return "not pangram";
        }
    }
}
