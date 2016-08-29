using Problems.Arrays;
using Problems.BinarySearch;
using Problems.DynamicProgramming;
using Problems.Leetcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new ZigZagConversion();
            List<char[]> result = null;
            int rows = 1;
            var output = p.Solution1("AB", rows, out result);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < result.Count; j++)
                {
                    if (result[j][i] == default(char))
                        Console.Write("  ");
                    else
                        Console.Write("{0} ", result[j][i].ToString());

                }
                Console.WriteLine();
            }
            Console.WriteLine(output);

        }
    }
}
