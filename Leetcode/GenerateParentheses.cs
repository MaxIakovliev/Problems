using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Leetcode
{
    /// <summary>
    /// https://leetcode.com/problems/generate-parentheses/
    /// </summary>
    public class GenerateParentheses
    {
        public List<string> GenerateParenthesis(int n)
        {
            List<String> res = new List<String>();
            if (n == 0)
            {
                return res;
            }
            helper(res, "", n, n);
            return res;
        }
        private void helper(List<String> res, String present, int left, int right)
        {
            if (right == 0)
            {
                res.Add(present);
            }
            if (left > 0)
            {
                helper(res, present + "(", left - 1, right);
            }
            if (right > left)
            {
                helper(res, present + ")", left, right - 1);
            }
        }
    }
}
