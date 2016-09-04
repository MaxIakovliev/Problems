using NUnit.Framework;
using Problems.Leetcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTest.Leetcode
{
    [TestFixture]
    public class MergeKSortedListsTest
    {
        IList<ListNode> _data;
        [SetUp]
        public void Init()
        {
            _data = new List<ListNode>();
            for (int i = 0; i < 3; i++)
            {
                ListNode pointer = null;
                ListNode current = null;
                var list = Enumerable.Range(0 * i, 2 * i).Reverse().ToList();
                foreach (var item in list)
                    if (current == null)
                    {
                        current = new ListNode(item * -1);
                        pointer = current;
                    }
                    else
                    {
                        pointer.next = new ListNode(item * -1);
                        pointer = pointer.next;
                    }
                _data.Add(current);
            }
        }

        [Test]
        public void MergeKListsTest()
        {
            var p = new MergeKSortedLists();
            var result = p.MergeKLists(_data.ToArray());

            while (result != null)
            {
                Console.WriteLine("{0} ", result.val);
                result = result.next;
            }
        }

        [Test]
        public void MergeKListsTest2()
        {
            var p = new MergeKSortedLists();

            var list = new ListNode(0);
            var tmp = list;
            tmp.next = new ListNode(2);
            tmp = tmp.next;
            tmp.next = new ListNode(5);


            var result = p.MergeKLists(new ListNode[] { list });

            while (result != null)
            {
                Console.WriteLine("{0} ", result.val);
                result = result.next;
            }
        }


        [Test]
        public void MergeKListsTest3()
        {
            var p = new MergeKSortedLists();

            ListNode pointer = null;
            ListNode current = null;
            var list = Enumerable.Range(1,7).ToList();
            foreach (var item in list)
                if (current == null)
                {
                    current = new ListNode(item );
                    pointer = current;
                }
                else
                {
                    pointer.next = new ListNode(item );
                    pointer = pointer.next;
                }


            var result = p.MergeKLists(new ListNode[] { current });

            while (result != null)
            {
                Console.WriteLine("{0} ", result.val);
                result = result.next;
            }
        }
    }
}
