using Problems.Arrays;
using Problems.BinarySearch;
using Problems.DynamicProgramming;
using Problems.Leetcode;
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
            var a = new int[] { 2, 4, 3 };
            var l1 = new ListNode(a[0]);
            var t = l1;
            for(int i=1;i<a.Length; i++)
            {
                t.next = new ListNode(a[i]);
                t = t.next;
            }

            a = new int[] { 5,6,4};
            var l2 = new ListNode(a[0]);
            t = l2;
            for (int i = 1; i < a.Length; i++)
            {
                t.next = new ListNode(a[i]);
                t = t.next;
            }

            var p = new AddTwoNumbers();
            var res = p.Solution2(l1, l2);

            while(res!=null)
            {
                Console.Write("{0} ",res.val);
                res = res.next;
            }
            Console.WriteLine();
        }
    }
}
