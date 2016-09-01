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
    public class LongestPalindromicSubstringTest
    {
        private List<Tuple<string, string>> _data;

        [SetUp]
        public void Init()
        {
            _data = new List<Tuple<string, string>>();
            _data.Add(new Tuple<string, string>("aba", "abac"));
            _data.Add(new Tuple<string, string>("Anna", "wwAnnasss"));
            _data.Add(new Tuple<string, string>("Civic", "aasacaCivicwqd"));
            _data.Add(new Tuple<string, string>("Kayak", "wwKayakssx"));
            _data.Add(new Tuple<string, string>("Level", "sscLevelwws"));
            _data.Add(new Tuple<string, string>("Madam", "Madam"));
            _data.Add(new Tuple<string, string>("Mom", "Momwdc"));
            _data.Add(new Tuple<string, string>("Noon", "aaxwaNoon"));
            _data.Add(new Tuple<string, string>("Racecar", "eecRacecaraaq"));
            _data.Add(new Tuple<string, string>("Radar", "wwdsRadardcq"));
            _data.Add(new Tuple<string, string>("Redder", "werRedderfds"));
            _data.Add(new Tuple<string, string>("Refer", "Refer"));
            _data.Add(new Tuple<string, string>("Repaper", "RepaperRepaper"));
            _data.Add(new Tuple<string, string>("Rotator", "Rotatorq1"));
            _data.Add(new Tuple<string, string>("Rotor", "sRotor1a"));
            _data.Add(new Tuple<string, string>("Sagas", "rrcxxwSagasqqaz"));
            _data.Add(new Tuple<string, string>("Solos", "Solosss"));
        }

        [Test]
        public void TestLongestPalindromicSubstringSolution1()
        {
            var p = new LongestPalindromicSubstring();
            foreach(var item in _data)
            {
                var result= p.Solution1(item.Item2);
                Console.WriteLine("input:{0}", item.Item2);
                Console.WriteLine("expected:{0}", item.Item1);
                Console.WriteLine("result:{0}", result);
                Assert.AreEqual(item.Item1, result);
                Console.WriteLine();
            }
        }
    }
}
