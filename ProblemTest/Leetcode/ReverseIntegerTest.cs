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
    public class ReverseIntegerTest
    {
        private List<Tuple<int, int>> _data;
        
        [SetUp]
        public void Init()
        {
            _data = new List<Tuple<int, int>>();
            _data.Add(new Tuple<int, int>(123, 321));
            _data.Add(new Tuple<int, int>(-123, -321));
            _data.Add(new Tuple<int, int>(1, 1));
            _data.Add(new Tuple<int, int>(234567890, 98765432));
            _data.Add(new Tuple<int, int>(1534236469, 0));
        }
        
        [Test]
        public void TestReverseInt()
        {
            var p = new ReverseInteger();
            foreach(var item in _data)
            {
                var result = p.Reverse(item.Item1);
                Console.WriteLine("input:{0}", item.Item1);
                Console.WriteLine("output:{0}", result);

                Console.WriteLine();
                Assert.AreEqual(item.Item2, result);
                

            }
        }
    }
}
