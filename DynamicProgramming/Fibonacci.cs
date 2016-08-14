using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.DynamicProgramming
{
    class Fibonacci
    {
        public decimal[] Solution1(int n)
        {
            var result = new decimal[n];
            if (n == 1)
                return new decimal[] { 0 };
            if (n == 2)
                return new decimal[] { 0, 1 };
            result[1] = 1;
            for(int i=2;i<n; i++)
                result[i] = result[i - 1] + result[i - 2];
            return result;
        }


        //How to test
        //static void Main(string[] args)
        //{
        //    var f = new Fibonacci();
        //    for (; ; )
        //    {
        //        var i = Convert.ToInt32(Console.ReadLine());
        //        var a = f.Solution1(i).ToList();
        //        a.ForEach(c => Console.Write("{0}, ", c));
        //        Console.WriteLine();
        //    }
        //}
    }
}
