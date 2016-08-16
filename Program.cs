using Problems.Arrays;
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
            var ks = new KSmallestElement();
            var arr = new int[] { 7, 10, 4, 3, 20, 15 };
            var result = ks.SortSolution(arr, 3);
            Console.WriteLine(result);
        }
    }
}
