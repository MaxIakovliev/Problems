using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Leetcode
{
    class _3SumClosest
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            int result = Int32.MaxValue/2;
            if (result == target)
                if (target == Int32.MaxValue)
                    result = Int32.MinValue;
                else if (target == Int32.MinValue)
                    result = Int32.MaxValue;
                else result = Int32.MinValue / 2;

            if (nums.Length < 3)
                return result;

            Array.Sort(nums);

            int left , right ;

            for (int i = 0; i < nums.Length-2; i++)
            {
                left = i + 1;
                right = nums.Length - 1;
                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if ( Math.Abs(target - result)>=Math.Abs(target - sum))
                    {
                        result = sum;
                        if (result == target) return result;
                    }
                    if (sum > target)
                        right--;
                    else
                        left++;
                }
                
            }
            return result;
        }
    }
}
