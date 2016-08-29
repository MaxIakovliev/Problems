using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Leetcode
{
    public class ReverseInteger
    {
        public int Reverse(int num)
        {
            if (num < 10 && num >=0) return num;
            var negative = num < 0;
            if (num < 0) num *= -1;
            var result = 0;
            try
            {
                checked
                {
                    while (num > 0)
                    {
                        result = result * 10 + num % 10;
                        num /= 10;
                    }
                }
            }
            catch
            {
                return 0;
            }
            return negative ? result * -1 : result;
        }
    }
}
