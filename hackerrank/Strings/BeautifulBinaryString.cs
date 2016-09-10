using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.hackerrank.Strings
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/beautiful-binary-string
    /// </summary>
    public  class BeautifulBinaryString
    {
        public int Solution1(string s)
        {
            var c = new Common();
            StringBuilder sb = new StringBuilder(s);
            int steps = 0;
           int n=-1;
            while((n=c.IndexOf(sb, "010"))>=0)
            {
                steps++;
                sb[n + 2] = '1';
            }
            return steps;
        }


    }
}
