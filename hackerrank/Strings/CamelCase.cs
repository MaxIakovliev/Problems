using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.hackerrank.Strings
{
    public class CamelCase
    {
        public int Solution1(string s)
        {
            int count = 1;
            for(int i=0; i<s.Length; i++)
            {
                if(char.IsUpper(s[i]))
                    count++;
            }
            Console.WriteLine(count);
            return count;
        }
    }
}
