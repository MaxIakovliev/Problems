using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Leetcode
{
    /// <summary>
    /// https://leetcode.com/problems/add-two-numbers/
    /// </summary>
    public class AddTwoNumbers
    {

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var stack = new Stack<int>();
            while(l1.next!=null)
            {
                stack.Push(l1.val);
                l1 = l1.next;
            }
            
            var sb = new StringBuilder(stack.Count());
            while (stack.Count > 0)
                sb.Append(stack.Pop());

            int num1 = Convert.ToInt16(sb.ToString());
            
            while (l2.next != null)
            {
                stack.Push(l1.val);
                l2 = l2.next;
            }
            sb = new StringBuilder(stack.Count());
            while (stack.Count > 0)
                sb.Append(stack.Pop());
            num1 = num1 + (Convert.ToInt32(sb.ToString()));
            sb = new StringBuilder(num1.ToString());

            var result = new ListNode(sb[sb.Length-1]);
            for (int i = sb.Length - 2; i >= 0; i--)
            {
                var t = new ListNode(sb[i]);
                result.next = t;
            }
            return result;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
