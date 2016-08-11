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
            var f = new Fibonacci();
            for (; ; )
            {
                var i = Convert.ToInt32(Console.ReadLine());
                var a = f.Solution1(i).ToList();
                a.ForEach(c => Console.Write("{0}, ", c));
                Console.WriteLine();
            }
        }
    }
}
