using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.hackerrank.Strings
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/game-of-thrones
    /// </summary>
    class GameofThronesI
    {
        public void Solution1(string s)
        {
            var dict = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                    dict.Add(s[i], 1);
                else
                    dict[s[i]] = dict[s[i]] + 1;
            }

            bool isEven = s.Length % 2 > 0 ? true : false;
            int countEven = 0;
            foreach (var item in dict)
            {
                if (item.Value % 2 > 0)
                    countEven++;
            }
            if (!isEven)
            {
                if (countEven ==0)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
            else
            {
                if (countEven ==1)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }

        }
    }
}
