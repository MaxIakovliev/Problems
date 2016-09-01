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
    class LongestSubstringWithoutRepeatingCharactersTest
    {
        private List<Tuple<int, string>> _data;
        private Random _rnd = new Random();
        [SetUp]
        public void Init()
        {
            _data = new List<Tuple<int, string>>();
            _data.Add(new Tuple<int, string>(3, "abcabc"));
            _data.Add(new Tuple<int, string>(4, "abcdabc"));
            _data.Add(new Tuple<int, string>(7, "abcdamlrd"));
            _data.Add(new Tuple<int, string>(0, ""));
            _data.Add(new Tuple<int, string>(1, "aa"));
            _data.Add(new Tuple<int, string>(2, "ab"));
            _data.Add(new Tuple<int, string>(2, "abb"));
            _data.Add(new Tuple<int, string>(2, "aba"));
            _data.Add(new Tuple<int, string>(2, "ababb"));
        }

        private string RandomString(int length)
        {
            const string chars = "_!#$%^&*()ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[_rnd.Next(s.Length)]).ToArray());
        }
        [Test]
        public void TestLongestSubString()
        {
            var p = new LongestSubstringWithoutRepeatingCharacters();
            for (int i = 0; i < _data.Count(); i++)
            {
                Console.WriteLine("Input:{0}", _data[i].Item2);
                var result = p.Solution3(_data[i].Item2);

                Console.WriteLine("result:{0}", result);
                Console.WriteLine();
                Assert.AreEqual(_data[i].Item1, result);
            }
        }
    }
}
