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
            var p = new TwoSum();
            var input = new int[] { 2, 7, 11, 15};
            var result = p.Solution1(input, 9);
            Console.WriteLine("{0}={2} {1}={3},", result[0], result[1], input[result[0]], input[result[1]]);
        }
    }
}
