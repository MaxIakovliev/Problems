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
   public class StringToIntegerTest
    {
        private List<Tuple<string, int>> _data;
        [SetUp]
        public void Init()
        {
            _data = new List<Tuple<string, int>>();
            _data.Add(new Tuple<string, int>("-2147483648", -2147483648));
            _data.Add(new Tuple<string, int>("2147483648", 2147483647));
            _data.Add(new Tuple<string, int>("", 0));
            _data.Add(new Tuple<string, int>("   - 321", 0));
            _data.Add(new Tuple<string, int>("   +0 123", 0));
            _data.Add(new Tuple<string, int>("+-1", 0));
            _data.Add(new Tuple<string, int>("+-", 0));
            _data.Add(new Tuple<string, int>("a", 0));
            _data.Add(new Tuple<string, int>("1", 1));
          
        }
        
        [Test]
        public void TestAtoI()
        {
            var p = new StringToInteger();
            foreach(var item in _data)
            {
                var res = p.AtoI(item.Item1);

                Console.WriteLine("input:{0}", item.Item1);
                Console.WriteLine("output:{0}", res);
                Console.WriteLine();
                Assert.AreEqual(item.Item2, res);
            }
        }
    }
}
