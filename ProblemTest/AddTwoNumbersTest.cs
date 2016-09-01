using NUnit.Framework;
using Problems.Leetcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTest
{
    [TestFixture]
    public class AddTwoNumbersTest
    {

        private List<TestTwoNumbersItem> data;

        private Random _rnd = new Random();

        [SetUp]
        public void Init()
        {
            data = new List<TestTwoNumbersItem>();
            int cout = _rnd.Next(1, 5000);
            for (int i = 0; i < cout; i++)
            {
                var num2 = _rnd.Next(10, Int16.MaxValue);
                var num1 = _rnd.Next(10, 10);
                var expected = num1 + num2;
                data.Add(new TestTwoNumbersItem
                {
                    _l1 = ToReversedListNode(num1),
                    _l2 = ToReversedListNode(num2),
                    Expexted = expected
                });
            }
        }
        
        [Test]
        public void TestAddTwoNumbersSolution1()
        {
            var p = new AddTwoNumbers();
            foreach(var item in data)
            {
                var result = p.Solution1(item._l1, item._l2);
                Console.Write("l1="); PrintListNode(item._l1);
                Console.Write("l2="); PrintListNode(item._l2);
                Console.Write("result="); PrintListNode(result);
                Console.WriteLine();
                Assert.AreEqual(item.Expexted, ListNodeToInt(result));
            }
        }


        [Test]
        public void TestAddTwoNumbersSolution2()
        {
            var p = new AddTwoNumbers();
            foreach (var item in data)
            {
                var result = p.Solution2(item._l1, item._l2);
                Console.Write("l1="); PrintListNode(item._l1);
                Console.Write("l2="); PrintListNode(item._l2);
                Console.Write("result="); PrintListNode(result);
                Console.WriteLine();
                Assert.AreEqual(item.Expexted, ListNodeToInt(result));
            }
        }



        [Test]
        public void TestAddTwoNumbersSolution3()
        {
            var p = new AddTwoNumbers();
            int i = 0;
            foreach (var item in data)
            {
                Console.WriteLine(i++);
                Console.Write("l1="); PrintListNode(item._l1);
                Console.Write("l2="); PrintListNode(item._l2);
                var result = p.Solution3(item._l1, item._l2);
                Console.Write("result="); PrintListNode(result);
                Assert.AreEqual(item.Expexted, ListNodeToInt(result));
            }
        }

        private decimal ListNodeToInt(ListNode n)
        {
            var t = n;
            var s = new List<string>();
            while(t!=null)
            {
                s.Add(t.val.ToString());
                t = t.next;
            }
            s.Reverse();
            return Convert.ToDecimal(String.Join("", s));
        }
        private void PrintListNode(ListNode n)
        {
            var t = n;
            while (t != null)
            {
                Console.Write("{0} ", t.val);
                t = t.next;
            }
            Console.WriteLine();
        }


        private ListNode ToReversedListNode(int num)
        {
            var s = num.ToString();
            var stack = new Stack<int>();
            for (int i = 0; i < s.Length; i++)
                stack.Push(Convert.ToInt32(s[i].ToString()));

            ListNode result = null;
            var t = result;
            while (stack.Count > 0)
            {
                if (result == null)
                {
                    result = new ListNode(stack.Pop());
                    t = result;
                }
                else
                {
                    t.next = new ListNode(stack.Pop());
                    t = t.next;
                }
            }
            return result;
        }


        private class TestTwoNumbersItem
        {
            public ListNode _l1 = null;
            public ListNode _l2 = null;
            public decimal Expexted;
        }
    }
}
