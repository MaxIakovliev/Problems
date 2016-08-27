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
            while (l1 != null)
            {
                stack.Push(l1.val);
                l1 = l1.next;
            }

            var sb = new StringBuilder(stack.Count());
            while (stack.Count > 0)
                sb.Append(stack.Pop());

            decimal num1 = Convert.ToDecimal(sb.ToString());

            while (l2 != null)
            {
                stack.Push(l2.val);
                l2 = l2.next;
            }
            sb = new StringBuilder(stack.Count());
            while (stack.Count > 0)
                sb.Append(stack.Pop());
            num1 = num1 + (Convert.ToDecimal(sb.ToString()));
            sb = new StringBuilder(num1.ToString());

            var result = new ListNode(Convert.ToInt32(sb[sb.Length - 1].ToString()));
            var b = result;
            for (int i = sb.Length - 2; i >= 0; i--)
            {
                var t = new ListNode(Convert.ToInt32(sb[i].ToString()));
                b.next = t;
                b = b.next;
            }
            return result;
        }


        public ListNode Solution2(ListNode l1, ListNode l2)
        {
            int next = 0;
            ListNode result = null;
            ListNode q = result;
            while (l1 != null && l2 != null)
            {
                int tmp = l1.val + l2.val + next;
                next = 0;
                if (tmp >= 10)
                {
                    if (result == null)
                    {
                        result = new ListNode(tmp % 10);
                        q = result;
                    }
                    else
                    {
                        q.next = new ListNode(tmp % 10);
                        q = q.next;
                    }
                    next = 1;
                }
                else
                {
                    if (result == null)
                    {
                        result = new ListNode(tmp);
                        q = result;
                    }
                    else
                    {
                        q.next = new ListNode(tmp);
                        q = q.next;
                    }
                }
                l1 = l1.next;
                l2 = l2.next;
            }

            ListNode tmpl = null;
            if (l1 != null)
                tmpl = l1;
            else if (l2 != null)
                tmpl = l2;

            while (tmpl != null)
            {
                int tmp = tmpl.val + next;
                next = 0;
                if (tmp >= 10)
                {
                    q.next = new ListNode(tmp % 10);
                    q = q.next;
                    next = 1;
                }
                else
                {
                    q.next = new ListNode(tmp);
                    q = q.next;
                }

                tmpl = tmpl.next;
            }

            if (next > 0)
                q.next = new ListNode(next);


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
