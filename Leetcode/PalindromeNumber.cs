using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Leetcode
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            var num = x;
            if (x < 10 && x >= 0) return true;
            int result = 0;
            bool negative = x < 0 ? true : false;
            while (x > 0)
            {
                if (negative)
                    result = (result * 10) - (x % 10);
                else
                    result = (result * 10) + (x % 10);
                x /= 10;
            }
            return result == num;
        }
    }
}
