using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.hackerrank.Strings
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/richie-rich
    /// </summary>
    public class RichieRich
    {
        public string Solution(string s, int num)
        {
            if (string.IsNullOrEmpty(s))
                return "-1";
            var sb = new StringBuilder(s);
            int start = 0; int end = s.Length - 1;
            var repl = new List<Tuple<char, int>>();
            int bonus = num % 2 > 0 ? 1 : 0;


            while (start < end)
            {
                if (s[start] != s[end])
                {
                    int a = Convert.ToInt32(s[start]);
                    int b = Convert.ToInt32(s[end]);

                    if (bonus == 1 && a != 9 && b != 9)
                    {
                        repl.Add(new Tuple<char, int>('9', end));
                        repl.Add(new Tuple<char, int>('9', start));
                        bonus = 0;
                    }
                    else if (a > b)
                        repl.Add(new Tuple<char, int>(s[start], end));
                    else
                        repl.Add(new Tuple<char, int>(s[end], start));
                }
                start++;
                end--;
            }
            if (repl.Count() > num)
                return "-1";

            for (int i = 0; i < repl.Count(); i++)
            {
                sb[repl[i].Item2] = repl[i].Item1;
                num--;
            }

            if (num >= 2 && num % 2 == 0)
            {
                start = 0;
                end = sb.Length - 1;
                while (start < end && num > 0)
                {
                    if (sb[start] != '9' && sb[end] != '9')
                    {
                        sb[start] = '9';
                        sb[end] = '9';
                        num = num - 2;
                    }
                    start++;
                    end--;
                }
            }

           


            return sb.ToString();
        }

        public string Solution2(string s, int num)
        {
            if (string.IsNullOrEmpty(s))
                return "-1";
            var sb = new StringBuilder(s);
            int bonus = (num>2 && num % 2 > 0 )? 1 : 0;
            int start = 0, end = sb.Length - 1;
            if(num>=sb.Length-1)
            {
                start = 0; end = sb.Length - 1;
                while (start <= end)
                {
                    if (num > 0 && sb[start]!='9')
                    {
                        sb[start] = '9';
                        num--;
                    }
                     

                    if (num > 0 && sb[end] != '9')
                    {
                        sb[end] = '9';
                        num--;
                    }
                    


                    start++;
                    end--;
                }

                return sb.ToString();

            }
            start = 0; 
            end = sb.Length - 1;
            
            while (start < end)
            {
                int a = Convert.ToInt32(sb[start]);
                int b = Convert.ToInt32(sb[end]);
                if(bonus==1 && a!=9 && b!=9)
                {
                    sb[start] = '9';
                    sb[end] = '9';
                    bonus = 0;
                    num = num - 2;
                }
                else if (a > b)
                {
                    if (num == 0)
                        return "-1";
                    sb[end] = sb[start];
                    num--;
                }
                else if (a < b)
                {
                    if (num == 0)
                        return "-1";
                    sb[start] = sb[end];
                    num--;
                }
                start++;
                end--;
            }
            if (num > 0 && num % 2 == 0)
            {
                start = 0; end = sb.Length - 1;
                while (start < end)
                {
                    if (sb[start] != '9' && num>1)
                    {
                        sb[start] = '9';
                        sb[end] = '9';
                        num = num - 2;
                    }
                    start++;
                    end--;
                }
            }

            if (sb.Length % 2 > 0 && num == 1)
            {
                var tmpIdx = (sb.Length - 1) / 2;
                sb[tmpIdx] = '9';
            }

            return sb.ToString();
        }

    }
}
