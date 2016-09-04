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
                var list = Enumerable.Range(0, 10 * i + 1).Reverse().ToList();
                foreach (var item in list)
                    if (current == null)
                    {
                        current = new ListNode(item);
                        pointer = current;
                    }
                    else
                    {
                        pointer.next = new ListNode(item);
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
    }
}
