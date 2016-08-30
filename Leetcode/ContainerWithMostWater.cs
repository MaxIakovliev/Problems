using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Leetcode
{
    public class ContainerWithMostWater
    {
        public int Solution(int[] heights)
        {
            if (heights == null || heights.Length < 2)
                return 0;

            int left = 0, right = heights.Length-1, max = 0;
            while(left<right)
            {
                max=Math.Max(max, Math.Min(heights[left], heights[right])*(right-left));
                if(heights[left]< heights[right])
                    left++;
                else
                    right--;
            }
            return max;

        }
    }
}
