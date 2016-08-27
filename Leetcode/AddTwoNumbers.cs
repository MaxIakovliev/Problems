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

        public ListNode Solution1(ListNode l1, ListNode l2)
        {
            var stack = new Stack<int>();
            while(l1!=null)
            {
                stack.Push(l1.val);
                l1 = l1.next;
            }
            
            var sb = new StringBuilder(stack.Count());
            while (stack.Count > 0)
                sb.Append(stack.Pop());

            int num1 = Convert.ToInt32(sb.ToString());
            
            while (l2 != null)
            {
                stack.Push(l2.val);
                l2 = l2.next;
            }
            sb = new StringBuilder(stack.Count());
            while (stack.Count > 0)
                sb.Append(stack.Pop());
            num1 = num1 + (Convert.ToInt32(sb.ToString()));
            sb = new StringBuilder(num1.ToString());

            var result = new ListNode(Convert.ToInt32( sb[sb.Length-1].ToString()));
            var b = result;
            for (int i = sb.Length - 2; i >= 0; i--)
            {
                var t = new ListNode(Convert.ToInt32(sb[i].ToString()));
                b.next = t;
                b = b.next;
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
