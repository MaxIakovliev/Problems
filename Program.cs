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
            var p = new MergeTwoSortedLists();
            var l1 = new ListNode(1);
            var l2 = new ListNode(1);
            var result = p.Solution1(l1, l2);
            //Console.WriteLine(r);

        }
    }
}
