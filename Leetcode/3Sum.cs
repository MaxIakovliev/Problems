using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Leetcode
{
    /// <summary>
    /// https://leetcode.com/problems/3sum/
    /// </summary>
    public class _3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            if (nums.Length < 3) return result;

            Array.Sort(nums);
           for (int i = 0; i < nums.Length; i++) 
            {
                if (i - 1 >= 0 && nums[i] == nums[i - 1]) continue;// Skip equal elements to avoid duplicates
                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    var sum = nums[i] + nums[left] + nums[right];
                    if (sum == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });
                        while (left + 1 < right && nums[left] == nums[left + 1])//skip equal elements to avoid duplications
                            left++;
                        while (right - 1 > left && nums[right] == nums[right - 1])//skip equal elements to avoid duplications
                            right--;

                        left++;
                        right--;
                    }
                    else if (sum < 0)
                        left++;
                    else if (sum > 0)
                        right--;
                }
            }
            return result;
        }
    }
}
