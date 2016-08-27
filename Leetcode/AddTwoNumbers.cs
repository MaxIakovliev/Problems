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




        public ListNode Solution3(ListNode l1, ListNode l2)
        {
            int next = 0;
            var ql1 = l1;
            var ql2 = l2;
            ListNode prevql1 = null;
            while (ql1 != null && ql2 != null)
            {
                int tmp = ql1.val + ql2.val + next;
                next = 0;
                if (tmp >= 10)
                {
                    ql1.val = tmp % 10;
                    next = 1;
                }
                else
                {
                    ql1.val = tmp;
                }
                prevql1 = ql1;
                ql1 = ql1.next;
                ql2 = ql2.next;
            }

            ListNode tmpl = null;

            if (ql1 != null)
                tmpl = ql1;
            else if (ql2 != null)
                tmpl = ql2;

            if (tmpl != null)
            {
                ListNode tl1 = null;
                var tl2 = tl1;
                ListNode prevql2 = null;
                while (tmpl != null)
                {
                    var tmp = tmpl.val + next;
                    next = 0;
                    if (tmp >= 10)
                    {
                        next = 1;
                        if (tl1 == null)
                        {
                            tl1 = new ListNode(tmp % 10);
                            tl2 = tl1;
                            prevql2 = tl1;
                        }
                        else
                        {
                            tl1.next = new ListNode(tmp % 10);
                            tl1 = tl1.next;
                            prevql2 = tl1;
                        }
                    }
                    else
                    {
                        if (tl1 == null)
                        {
                            tl1 = new ListNode(tmp);
                            tl2 = tl1;
                            prevql2 = tl1;
                        }
                        else
                        {
                            tl1.next = new ListNode(tmp);
                            tl1 = tl1.next;
                            prevql2 = tl1;
                        }
                    }
                    tmpl = tmpl.next;
                }

                ql1 = prevql1;

                if (tl2 != null)
                    ql1.next = tl2;

                 

                prevql1 = prevql2;
            }

           

            if (next > 0)
            {
                ql1 = prevql1;
                ql1.next = new ListNode(next);
            }

            return l1;
        }

    }








    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
