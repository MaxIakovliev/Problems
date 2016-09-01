using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Leetcode
{
    /// <summary>
    /// 
    /// </summary>
    public class ValidParentheses
    {
        public bool Solution1(string s)
        {
            if (s.Length % 2 != 0) return false;
            var close = new Stack<char>();
            char c1 = ')', c2 = '}', c3 = ']';
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '(':
                        close.Push(c1);
                        break;
                    case '{':
                        close.Push(c2);
                        break;
                    case '[':
                        close.Push(c3);
                        break;

                    case ')':

                    case ']':

                    case '}':
                        if (close.Count == 0 || close.Pop() != s[i])
                            return false;
                        break;
                    default: break;

                }
            }
            return close.Count == 0 ? true : false;
        }
    }
}
