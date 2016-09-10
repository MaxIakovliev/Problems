using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.hackerrank.Strings
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/funny-string
    /// </summary>
    public class FunnyString
    {
        public List<string> Solution1(List<string> input)
        {
            var dict = new Dictionary<char, int>();
            var result = new List<string>();
            var tpl = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < tpl.Length; i++)
            {
                dict.Add(tpl[i], i);
            }

            var t = new List<Task<Tuple<int, string>>>();

            for (int i = 0; i < input.Count; i++)
            {
                var cur = input[i];
                int curi = i;
                //t.Add(Task.Factory.StartNew<Tuple<int, string>>(() =>
                //{
                int start = 1, end = cur.Length - 2;
                while (start < cur.Length - 1 && end > 0)
                {
                    if (Math.Abs(dict[cur[start]] - dict[cur[start - 1]]) != Math.Abs(dict[cur[end]] - dict[cur[end + 1]]))
                        //return new Tuple<int, string>(curi, "Not Funny");
                        result.Add("Not Funny");
                    start++;
                    end--;
                }
                // return new Tuple<int, string>(curi, "Funny");
                result.Add("Funny");
                //}));
            }

            //Task.WaitAll(t.ToArray());
            //var result = t.OrderBy(c => c.Result.Item1).Select(c => c.Result.Item2).ToList<string>();

            foreach (var item in result)
                Console.WriteLine(item);
            return result;
        }

    }
}
