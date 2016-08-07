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
            var arr = new MaxProductSubArray();
            var data= new int[]{2,3, -2, 8, 200, -1, 12, 15};
            var result = arr.Solution1(data);

            foreach (var item in result)
                Console.Write(" {0}", item);

            Console.WriteLine();
           
        
        }
    }
}
