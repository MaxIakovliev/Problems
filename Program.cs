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
            var p = new GenerateParentheses();
            
            var result = p.GenerateParenthesis(3);

            foreach (var item in result)
                Console.WriteLine(item);

        }
    }
}
