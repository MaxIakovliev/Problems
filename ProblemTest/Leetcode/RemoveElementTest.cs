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
    public class RemoveElementTest
    {
        /// <summary>
        /// 1.input
        /// 2.item to remove
        /// 3.expected output len
        /// 4 expected output
        /// </summary>
        private List<Tuple<int[], int, int, int[]>> _d;

        [SetUp]
        public void Init()
        {
            _d = new List<Tuple<int[], int, int, int[]>>();
            _d.Add(new Tuple<int[], int, int, int[]>(null, 0, 0, null));
            _d.Add(new Tuple<int[], int, int, int[]>(new int[] { 1 }, 2, 1, new int[] { 1 }));
            _d.Add(new Tuple<int[], int, int, int[]>(new int[] { 1 }, 1, 0, new int[] { }));
            _d.Add(new Tuple<int[], int, int, int[]>(new int[] { 1, 1 }, 1, 0, new int[] { }));
            _d.Add(new Tuple<int[], int, int, int[]>(new int[] { 1, 1, 2 }, 1, 1, new int[] { 2 }));
            _d.Add(new Tuple<int[], int, int, int[]>(new int[] { 1, 1, 2, 1 }, 1, 1, new int[] { 2 }));
            _d.Add(new Tuple<int[], int, int, int[]>(new int[] { 1, 2, 1 }, 1, 1, new int[] { 2 }));
            _d.Add(new Tuple<int[], int, int, int[]>(new int[] { 2, 1, 1 }, 1, 1, new int[] { 2 }));
            _d.Add(new Tuple<int[], int, int, int[]>(new int[] { 2, 1, 1 }, 3, 3, new int[] { 2, 1, 1 }));
        }

        [Test]
        public void TestRemoveElement()
        {

            var p = new RemoveElement();
            int c = 0;
            foreach (var item in _d)
            {
                var res = p.Solution1(item.Item1, item.Item2);
                Console.WriteLine(c++);
                Assert.AreEqual(item.Item3, res);

            }
        }
    }
}
