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
            var arr = new KadanesMaximumSumSubarray();
            var a = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            var result = arr.Solution(a);
            foreach (var item in a)
                Console.Write("{0} ", item);
            Console.WriteLine();

            for (int i = result.Item1; i <= result.Item2; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();
            Console.WriteLine("max sum={0}", result.Item3);

        }
    }
}
