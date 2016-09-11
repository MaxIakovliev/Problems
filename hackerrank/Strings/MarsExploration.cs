using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.hackerrank.Strings
{
    public class MarsExploration
    {
        public int Solution1(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            var count = 0;
            int i = 0;
            while (i < s.Length - 2)
            {
                if (s[i] != 'S')
                    count++;
                if (s[i + 1] != 'O')
                    count++;
                if (s[i + 2] != 'S')
                    count++;
                i += 3;
            }
            return count;
        }
    }
}
