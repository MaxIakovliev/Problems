using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Leetcode
{
    public class SwapNodesInPairs
    {
        public ListNode SwapPairs2(ListNode head)
        {

            var tmp = head;
            ListNode prev = null;
            bool firstStep = true;
            while (true)
            {
                if (tmp == null)
                    break;

                if (tmp.next == null)
                {
                    break;
                }

                if (tmp.next.next == null)
                {
                    var a1 = tmp;
                    var b1 = tmp.next;
                    b1.next = a1;

                    if (firstStep)
                    {
                        head = b1;
                        firstStep = false;
                        prev = a1;
                    }
                    else
                    {
                        prev.next = b1;
                        prev = prev.next;
                        prev = prev.next;
                    }
                    break;
                }

                var a = tmp;
                var b = tmp.next;
                var c = tmp.next.next;


                a.next = c;
                b.next = a;

                if (firstStep)
                {
                    head = b;
                    firstStep = false;
                    prev = a;
                }
                else
                {
                    prev.next = b;
                    prev = prev.next;
                    prev = prev.next;

                }

                tmp = c;


            }
            return head;
        }


        public ListNode SwapPairs3(ListNode head)
        {

            var tmp = head;
            ListNode prev = null;
            bool firstStep = true;
            ListNode a = null, b = null, c = null;
            while (true)
            {
                if (tmp == null ||tmp.next == null)
                    return head;

                if (tmp.next.next == null)
                {
                    a = tmp;
                    b = tmp.next;
                    b.next = a;

                    if (firstStep)
                    {
                        head = b;
                        firstStep = false;
                        prev = a;
                    }
                    else
                    {
                        prev.next = b;
                        prev = prev.next;
                        prev = prev.next;
                    }
                    return head ;
                }

                 a = tmp;
                 b = tmp.next;
                 c = tmp.next.next;


                a.next = c;
                b.next = a;

                if (firstStep)
                {
                    head = b;
                    firstStep = false;
                    prev = a;
                }
                else
                {
                    prev.next = b;
                    prev = prev.next;
                    prev = prev.next;

                }

                tmp = c;


            }
            return null;
        }



        public ListNode SwapPairs(ListNode head)
        {

            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode current = dummy;
            while (current.next != null && current.next.next != null)
            {
                ListNode first = current.next;
                ListNode second = current.next.next;
                first.next = second.next;
                current.next = second;
                current.next.next = first;
                current = current.next.next;
            }
            return dummy.next;
        }
    }
}
