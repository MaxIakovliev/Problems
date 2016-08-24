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
            var input = new int[] {7,8,3,4,7};//0,4,0,90 };//2, 7, 11, 15};
            int target = 15;
            var result = p.Solution1(input,target);//0); //9);
            Console.WriteLine("{0}, {1}; {2},{3},", result[0], result[1], input[result[0]], input[result[1]]);
            Console.WriteLine(input[result[0]] + input[result[1]] == target);
        }
    }
}
