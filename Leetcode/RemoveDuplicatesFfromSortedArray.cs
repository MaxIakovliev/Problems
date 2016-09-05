using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Leetcode
{
    public class RemoveDuplicatesFfromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 2) return nums.Length;

            var idx=1;
            for (int i = 1; i < nums.Length; i++)
                if (nums[i] != nums[i - 1])
                    nums[idx++] = nums[i];

            return idx;
        }
    }
}
