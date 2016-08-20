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
            var p = new NextGreaterElement();
            var r = p.Solution1(new int[] { 4, 5, 2, 25 });
            for (int i = 0; i < r.Length; i++)
                Console.WriteLine("{0}->{1} ", r[i].Item1, r[i].Item2);
        }
    }
}
