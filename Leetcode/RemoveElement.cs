using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Leetcode
{
    /// <summary>
    /// https://leetcode.com/problems/remove-element/
    /// </summary>
    public class RemoveElement
    {
        public int Solution1(int[] arr, int val)
        {
            if (arr == null || arr.Length == 0) return 0;
            var count = arr.Length;
            int start = 0;
            int end = arr.Length - 1;
            while (start <= end)
            {
                while (end > 0 && arr[end] == val)
                {
                    count--;
                    end--;
                }


                if (arr[start] == val && start <= end)
                {
                    Swap(arr, start, end);
                    count--;
                    end--;
                }
                start++;
            }
            return count;
        }
        private void Swap(int[] arr, int start, int end)
        {
            int tmp = arr[start];
            arr[start] = arr[end];
            arr[end] = tmp;
        }
    }
}
