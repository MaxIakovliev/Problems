using Problems.Arrays;
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
            var s = new IncreasingSubsequenceOfLengthThreeWithMaxProduct();
            Console.WriteLine("Case1");
            s.Solution1(new int[] { 6, 7, 8, 1, 2, 3, 9, 10 });

            Console.WriteLine("Case2");
            s.Solution1(new int[] { 1, 5, 10, 8, 9 });
            Console.WriteLine();
        }
    }
}
