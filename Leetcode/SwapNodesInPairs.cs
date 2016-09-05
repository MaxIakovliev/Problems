using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Leetcode
{
    public class SwapNodesInPairs
    {
        public ListNode SwapPairs(ListNode head)
        {

            var tmp = head;
            //var s = new ListNode[3];
            //ListNode a = null, b = null, c = null, 
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
    }
}
