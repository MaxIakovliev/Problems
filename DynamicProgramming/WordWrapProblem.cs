using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.DynamicProgramming
{
    /// <summary>
    /// http://www.geeksforgeeks.org/dynamic-programming-set-18-word-wrap/
    /// Given a sequence of words, and a limit on the number of characters that can be put in one line (line width). 
    /// Put line breaks in the given sequence such that the lines are printed neatly. 
    /// Assume that the length of each word is smaller than the line width.
    /// </summary>
    class WordWrapProblem
    {
        public string Solution1(string s, int max)
        {
            var words = s.Split(' ');
            var matrix = new int[words.Length, words.Length];
            for (int i = 0; i < words.Length; i++)
                for (int j = i; j < words.Length; j++)
                {
                    matrix[i, j] = CalcLength(words, i, j, max);
                }

            var min = new int[words.Length];
            var result = new int[words.Length];

            for(int i=words.Length; i>=0; i--)
            {
                min[i] = matrix[i, words.Length - 1];
                result[i] = words.Length;
                for(int j=words.Length-1; j>=0; j--)
                {
                    if (matrix[i, j - 1] == -1)
                        continue;

                    if(min[i]>min[j]+matrix[i,j-1])
                    {
                        min[i] = min[j] + matrix[i, j - 1];
                        result[i] = j;
                    }
                }
            }

            var b = new StringBuilder();
            int m,n;
                m=n=0;
                do
                {
                    m = result[n];
                    for (int k = 0; k < m; k++)
                    {
                        b.Append(words[k] + " ");
                    }
                    b.Append("\n");
                    n = m;
                } while (m < words.Length);
                return b.ToString();
        }

        private int CalcLength(string[] m, int i, int j, int limit)
        {
            int len = 0;
            for (int k = i; k < j; k++)
            {
                len += m[k].Length;
            }
            if (j > 0)
                len += (j - i) - 1;

            if (len > limit)
                return -1;
            else
                return (limit - len) * (limit - len);
        }
    }
}
