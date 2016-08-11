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
    }
}
