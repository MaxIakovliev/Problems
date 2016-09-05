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
    public class SwapNodesInPairsTest
    {
        [Test]
        public void TestSwapNodes1()
        {
            var input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var output = new int[] { 2, 1, 4, 3, 6, 5, 8, 7 };
            var p = new SwapNodesInPairs();

            ListNode data = null;
            ListNode tmp = null;

            for (int i = 0; i < input.Length; i++)
            {
                if (data == null)
                {
                    data = new ListNode(input[i]);
                    tmp = data;
                }
                else
                {
                    tmp.next = new ListNode(input[i]);
                    tmp = tmp.next;
                }
            }
            var result = p.SwapPairs(data);
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("expected:{0}, actual{1}", output[i], result.val);
                Assert.AreEqual(output[i], result.val);
                result = result.next;
            }
        }

        [Test]
        public void TestSwapNodes2()
        {
            var input = new int[] { 1, 2, 3, 4, 5, 6, 7, };
            var output = new int[] { 2, 1, 4, 3, 6, 5, 7 };
            var p = new SwapNodesInPairs();

            ListNode data = null;
            ListNode tmp = null;

            for (int i = 0; i < input.Length; i++)
            {
                if (data == null)
                {
                    data = new ListNode(input[i]);
                    tmp = data;
                }
                else
                {
                    tmp.next = new ListNode(input[i]);
                    tmp = tmp.next;
                }
            }
            var result = p.SwapPairs(data);
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("expected:{0}, actual{1}", output[i], result.val);
                Assert.AreEqual(output[i], result.val);
                result = result.next;
            }
        }

        [Test]
        public void TestSwapNodes3()
        {
            var input = new int[] { 1, 2, 3, };
            var output = new int[] { 2, 1, 3};
            var p = new SwapNodesInPairs();

            ListNode data = null;
            ListNode tmp = null;

            for (int i = 0; i < input.Length; i++)
            {
                if (data == null)
                {
                    data = new ListNode(input[i]);
                    tmp = data;
                }
                else
                {
                    tmp.next = new ListNode(input[i]);
                    tmp = tmp.next;
                }
            }
            var result = p.SwapPairs(data);
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("expected:{0}, actual{1}", output[i], result.val);
                Assert.AreEqual(output[i], result.val);
                result = result.next;
            }
        }
    }
}
