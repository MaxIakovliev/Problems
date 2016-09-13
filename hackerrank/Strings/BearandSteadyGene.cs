using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.hackerrank.Strings
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/bear-and-steady-gene
    /// </summary>
    class BearandSteadyGene
    {
        


        public void Solution2(string s)
        {
            int a = 0, c = 0, t = 0, g = 0, result = 0;
            var min = s.Length / 4;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'A') a++;
                if (s[i] == 'C') c++;
                if (s[i] == 'T') t++;
                if (s[i] == 'G') g++;
            }

            if (a != min || c != min || t != min || g != min)
            {
                result = s.Length + 1;  // set to max
                // scan the gene to find the smallest subLength 
                for (int right = 0, left = 0; right < s.Length; right++)
                {
                    if (s[right] == 'A') a--;
                    if (s[right] == 'C') c--;
                    if (s[right] == 'G') g--;
                    if (s[right] == 'T') t--;
                    while (a <= min && c <= min && g <= min
                           && t <= min && left <= right)
                    {
                        result = Math.Min(result, right - left + 1);
                        if (s[left] == 'A') a++;
                        if (s[left] == 'C') c++;
                        if (s[left] == 'G') g++;
                        if (s[left] == 'T') t++;
                        left++;
                    }
                }
            }
            Console.WriteLine(result);

        }
    }
}
