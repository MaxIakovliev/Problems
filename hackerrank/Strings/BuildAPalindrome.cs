using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.hackerrank.Strings
{
    class BuildAPalindrome
    {
        public void Solution1(string s1, string s2)
        {
            var dict = new Dictionary<char, int>();
            var direction = "abcdefghijklmnopqrstuvwxyz";
            s1 = s1 + s2;
            for (int i = 0; i < s1.Length; i++)
            {
                if (!dict.ContainsKey(s1[i]))
                    dict.Add(s1[i], 1);
                else
                    dict[s1[i]] = dict[s1[i]] + 1;
            }
            char? mid = null;
            var sb = new StringBuilder();
            int iter = 0;
            for (int i = 0; i < direction.Length; i++)
            {
                if (dict.ContainsKey(direction[i]) && dict[direction[i]] == 1 && mid == null)
                    mid = direction[i];

                else if (dict.ContainsKey(direction[i]) && dict[direction[i]] % 2 == 0)
                {
                    int j = 0;
                    while (j < dict[direction[i]])
                    {
                        sb.Insert(iter, direction[i].ToString() + direction[i].ToString());
                        iter++;
                        j += 2;
                    }
                }
            }
            if (mid != null && sb.Length > 0)
                sb.Insert(iter, mid.Value.ToString());

            var m = 0;
            while (m < sb.Length - 1)
            {
                if (sb[m] == sb[m + 1])
                {
                    sb.Remove(m, 2);
                    m = 0;
                }
                else
                    m++;
            }

            if (sb.Length > 0)
                Console.WriteLine(sb.ToString());
            else
                Console.WriteLine("-1");


        }


        public void Solution2(string s1, string s2)
        {
            int start1 = 0, end1 = s1.Length - 1, start2 = 0, end2 = s2.Length - 1;
            var list=new List<Tuple<int,int,int,int,int >>();
            while (start1 < end1)
            {
                while (start2 < end2)
                {
                    if (s1[start1] != s2[end2])
                        end2--;
                    else if (s1[end1] != s2[start2])
                        start2++;
                    else
                    {
                        if(IsPalindrome(s1.Substring(start1, end1 - start1) + s2.Substring(start2, end2 - start2)))
                        {
                            list.Add(new Tuple<int, int, int, int, int>(start1, end1, start2, end2, (end2-start2)+ (end1-start1)));
                        }
                    }
                }
                end1--;
            }

            start1 = 0; end1 = s1.Length - 1; start2 = 0; end2 = s2.Length - 1;
            while (start1 < end1)
            {
                while (start2 < end2)
                {
                    if (s1[start1] != s2[end2])
                        end2--;
                    else if (s1[end1] != s2[start2])
                        start2++;
                    else
                    {
                        if (IsPalindrome(s1.Substring(start1, end1 - start1) + s2.Substring(start2, end2 - start2)))
                        {
                            list.Add(new Tuple<int, int, int, int, int>(start1, end1, start2, end2, (end2 - start2) + (end1 - start1)));
                        }
                    }
                }
                start1++;
            }


            start1 = 0; end1 = s1.Length - 1; start2 = 0; end2 = s2.Length - 1;



            while (start2 < end2)
            {
                while (start1 < end1)
                {
                    if (s1[start1] != s2[end2])
                        end1--;
                    else if (s1[end1] != s2[start2])
                        start1++;
                    else
                    {
                        if (IsPalindrome(s1.Substring(start1, end1 - start1) + s2.Substring(start2, end2 - start2)))
                        {
                            list.Add(new Tuple<int, int, int, int, int>(start1, end1, start2, end2, (end2 - start2) + (end1 - start1)));
                        }
                    }
                }
                end2--;
            }

            start1 = 0; end1 = s1.Length - 1; start2 = 0; end2 = s2.Length - 1;
            while (start2 < end2)
            {
                while (start1 < end1)
                {
                    if (s1[start1] != s2[end2])
                        end1--;
                    else if (s1[end1] != s2[start2])
                        start1++;
                    else
                    {
                        if (IsPalindrome(s1.Substring(start1, end1 - start1) + s2.Substring(start2, end2 - start2)))
                        {
                            list.Add(new Tuple<int, int, int, int, int>(start1, end1, start2, end2, (end2 - start2) + (end1 - start1)));
                        }
                    }
                }
                start2++;
            }

            if (list.Count == 0)
            {
                Console.WriteLine(-1);
                return;
            }



        }

        private bool IsPalindrome(string s)
        {
            int start = 0, end = s.Length - 1;
            while (start < end)
            {
                if (s[start] != s[end])
                    return false;

                start++;
                end--;
            }
            return true;
        }
    }
}
