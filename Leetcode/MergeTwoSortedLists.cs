using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Leetcode
{
    public class MergeTwoSortedLists
    {
        public ListNode Solution1(ListNode l1, ListNode l2)
        {
            ListNode result = null;
            ListNode tmp = null;
            while (true)
            {
                if (l1 == null && l2 == null) return result;

                if (l1 == null && l2 != null)
                {
                    if (result == null)
                    {
                        result = new ListNode(l2.val);
                        tmp = result;
                    }
                    else
                    {
                        //if (l2.val == result.val)
                        //    l2 = l2.next;
                        //else
                            tmp.next = new ListNode(l2.val);
                    }
                    l2 = l2.next;
                }
                else if (l2 == null && l1 != null)
                {
                    if (result == null)
                    {
                        result = new ListNode(l1.val);
                        tmp = result;
                    }
                    else
                    {
                        //if (l1.val == result.val)
                        //    l1 = l1.next;
                        //else
                            tmp.next = new ListNode(l1.val);
                    }
                    l1 = l1.next;
                }
                else if (l1.val <= l2.val)
                {
                    if (result == null)
                    {
                        result = new ListNode(l1.val);
                        tmp = result;
                    }
                    else
                    {
                        //if (l1.val != result.val)
                            tmp.next = new ListNode(l1.val);
                    }
                    //if (l1.val == l2.val)
                    //    l2 = l2.next;

                    l1 = l1.next;
                }
                else
                {
                    if (result == null)
                    {
                        result = new ListNode(l2.val);
                        tmp = result;
                    }
                    else
                    {
                        //if (l2.val != result.val)
                            tmp.next = new ListNode(l2.val);
                    }
                    //if (l1.val == l2.val)
                    //    l1 = l1.next;

                    l2 = l2.next;
                }
                if (tmp.next != null)
                    tmp = tmp.next;
            }
            return result;
        }
    }

}
