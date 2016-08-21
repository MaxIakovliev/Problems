using Problems.Arrays;
using Problems.BinarySearch;
using Problems.DynamicProgramming;
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
            var p = new ArithmeticProgressionSearch();
            var arr = new int[] { 1, 3, 7, 9, 11, 13 };
            var result = p.Solution(arr);
            Console.WriteLine(result);

        }
    }
}
