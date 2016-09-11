using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.hackerrank.Strings
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/palindrome-index
    /// </summary>
    public class PalindromeIndex
    {
        public List<int> Solution1(List<string> s)
        {
            var result = new List<int>();
            for (int i = 0; i < s.Count; i++)
            {
                string p = s[i];
                int start = 0, end = p.Length - 1;
                int res = -1;
                while (start <= end)
                {
                    if (p[start] != p[end])
                    {
                        if(IsPaindrome(p,start+1,end))
                        {
                            res = start;
                            result.Add(res);
                            Console.WriteLine(res);
                        }
                        else
                        {
                            res = end;
                            result.Add(res);
                            Console.WriteLine(res);
                        }
                        break;
                         
                    }
                    start++;
                    end--;
                }
                if (res == -1)
                {
                    Console.WriteLine(res);
                    result.Add(res);
                
                }

            }
            return result;
        }


        private bool IsPaindrome(string p, int start, int end)
        {
            while (start <= end)
            {
                if (p[start] != p[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }

    }
}
