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
            var p = new _3SumClosest();
            var r = p.ThreeSumClosest(new int[] { 1, 1, -1, -1, 3 }, -1);
            Console.WriteLine(r);

        }
    }
}
