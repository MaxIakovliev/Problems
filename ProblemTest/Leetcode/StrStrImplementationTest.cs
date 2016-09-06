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
    public class StrStrImplementationTest
    {
        private List<Tuple<string, int, string>> _d;
        [SetUp]
        public void Init()
        {
            _d = new List<Tuple<string, int, string>>();
            _d.Add(new Tuple<string, int, string>("", 0, ""));
            _d.Add(new Tuple<string, int, string>("abc", -1, "d"));
            _d.Add(new Tuple<string, int, string>("abc", 0, "a"));
            _d.Add(new Tuple<string, int, string>("aac", 0, "a"));
            _d.Add(new Tuple<string, int, string>("abc", 1, "b"));
            _d.Add(new Tuple<string, int, string>("abcd", 1, "bc"));
            _d.Add(new Tuple<string, int, string>("aqqwbcd", 3, "wbc"));
            _d.Add(new Tuple<string, int, string>("aqqwbqqccd", 5, "qqc"));
            _d.Add(new Tuple<string, int, string>("mississippi", 4, "issip"));
            _d.Add(new Tuple<string, int, string>("mississippi", 6, "sipp"));
        }
        
        [Test]
        public void TestStrStrFunction()
        {
            var p = new StrStrImplementation();
            int count = 0;
            foreach(var item in _d)
            {
                Console.WriteLine(count++);
                var res = p.StrStr(item.Item1, item.Item3);
                Assert.AreEqual(item.Item2, res);
            }
        }
    }
}
