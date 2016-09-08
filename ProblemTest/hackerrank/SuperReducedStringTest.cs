using NUnit.Framework;
using Problems.hackerrank.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTest.hackerrank
{
    [TestFixture]
    public class SuperReducedStringTest
    {
        private List<Tuple<string, string>> _d;

        [SetUp]
        public void Init()
        {
            _d = new List<Tuple<string, string>>();

            _d.Add(new Tuple<string, string>("aaabccddd", "abd"));
            _d.Add(new Tuple<string, string>("baab", "Empty String"));
            _d.Add(new Tuple<string, string>("aa", "Empty String"));
            _d.Add(new Tuple<string, string>("aaabccddd", "abd"));
            _d.Add(new Tuple<string, string>("zztqooauhujtmxnsbzpykwlvpfyqijvdhuhiroodmuxiobyvwwxupqwydkpeebxmfvxhgicuzdealkgxlfmjiucasokrdznmtlwh", "tqauhujtmxnsbzpykwlvpfyqijvdhuhirdmuxiobyvxupqwydkpbxmfvxhgicuzdealkgxlfmjiucasokrdznmtlwh"));
        }

        [Test]
        public void SuperReducedStringSolution1Test()
        {
            var p = new SuperReducedString();
            var count = 0;
            foreach(var item in _d)
            {
                Console.WriteLine(count++);
                var res = p.Solution1(item.Item1);
                Assert.AreEqual(item.Item2, res);
            }
        }
    }
}
