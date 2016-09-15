using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.hackerrank.Strings
{
    public class BuildAPalindrome
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
            int start1 = 0, end1 = 1, start2 = 0, end2 = 1;
            var list = new List<Tuple<int, int, int, int, int>>();

            while (start1 < s1.Length)
            {
                if (end1 + start1 >= s1.Length + 1)
                {
                    start1++;
                    //end1 = start1 + 1;
                    end1 = 1;
                }
                if (end1 + start1 >= s1.Length + 1)
                    continue;

                start2 = 0;
                //end2 = start2 + 1;
                end2 = 1;
                while (start2 < s2.Length)
                {
                    if (end2 + start2 >= s2.Length + 1)
                    {
                        start2++;
                        end2 = 1;

                    }
                    if (end2 + start2 >= s2.Length + 1)
                        continue;


                    var str = s1.Substring(start1, end1) + s2.Substring(start2, end2);
                    if (IsPalindrome(str))
                    {
                        list.Add(new Tuple<int, int, int, int, int>(start1, end1, start2, end2, str.Length));
                    }
                    end2++;

                }

                end1++;
            }


            if (list.Count == 0)
            {
                Console.WriteLine(-1);
                return;
            }

            var max = list.Max(c => c.Item5);

            var allmax = list.Where(c => c.Item5 == max).Select(c => c).ToList();
            var output = new List<string>();
            foreach (var it in allmax)
            {
                output.Add(s1.Substring(it.Item1, it.Item2) + s2.Substring(it.Item3, it.Item4));
            }
            output.Sort();
            Console.WriteLine(output[0]);

        }


        public void Solution3(string s1, string s2)
        {
            int start1 = 0, end1 = s1.Length, start2 = 0, end2 = 1;
            var list = new List<Tuple<int, int, int, int, int>>();
            int otboy = -1;
            while (start1 < s1.Length)
            {
                if (end1 ==0)
                {
                    start1++;
                    end1 = s1.Length-start1;
                }
                if (end1 == 0)
                    continue;

                start2 = 0;
                end2 = s2.Length;
                while (start2 < s2.Length)
                {
                    if (otboy > 0 && otboy > (end1+end2))
                    {
                        start2++;
                        end2 = s2.Length - start2;
                    }
                    else
                    {

                        if (end2 == 0)
                        {
                            start2++;
                            end2 = s2.Length - start2;

                        }
                        if (end2 == 0)
                            continue;



                        var str = s1.Substring(start1, end1) + s2.Substring(start2, end2);
                        if (IsPalindrome(str))
                        //if (IsPalindrome(s1,en)
                        {                            
                            list.Add(new Tuple<int, int, int, int, int>(start1, end1, start2, end2, str.Length));
                            otboy = str.Length;
                        }
                        end2--;
                    }

                }

                end1--;
            }


            if (list.Count == 0)
            {
                Console.WriteLine(-1);
                //continue; //UNCOMMENT IT
                return;
            }

            var max = list.Max(c => c.Item5);

            var allmax = list.Where(c => c.Item5 == max).Select(c => c).ToList();
            var output = new List<string>();
            foreach (var it in allmax)
            {
                output.Add(s1.Substring(it.Item1, it.Item2) + s2.Substring(it.Item3, it.Item4));
            }
            output.Sort();
            Console.WriteLine(output[0]);

        }

        private static readonly object locker = new object();

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

        //private bool IsPalindrome(string s1, int s1s, int s1e , string s2, int s2s, int s2e)
        //{
        //    int start = s1s, end=s1s+;



        //    while (start < end)
        //    {
        //        if (start <= s1len && end > s1len+1)
        //        {
        //            if (s1[start] != s2[end])
        //                return false;
        //        }
        //        else if(start<=s1len &&end<=s1len)
        //        {
        //            if (s1[start] != s1[end])
        //                return false;
        //        }
        //        else if(start>s1len && end>s1len)
        //        {
        //            if (s1[start] != s2[end])
        //                return false;
        //        }
        //        //if (s[start] != s[end])
        //        //    return false;

        //        start++;
        //        end--;
        //    }
        //    return true;
        //}
    }
}
