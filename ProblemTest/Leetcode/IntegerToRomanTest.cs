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
    public class IntegerToRomanTest
    {
        private List<Tuple<string, int>> _data;
        [SetUp]
        public void Init()
        {
            _data = new List<Tuple<string, int>>();
            _data.Add(new Tuple<string, int>("I", 1));
            _data.Add(new Tuple<string, int>("II", 2));
            _data.Add(new Tuple<string, int>("III", 3));
            _data.Add(new Tuple<string, int>("IV", 4));
            _data.Add(new Tuple<string, int>("V", 5));
            _data.Add(new Tuple<string, int>("VI", 6));
            _data.Add(new Tuple<string, int>("VII", 7));
            _data.Add(new Tuple<string, int>("VIII", 8));
            _data.Add(new Tuple<string, int>("IX", 9));
            _data.Add(new Tuple<string, int>("X", 10));
            _data.Add(new Tuple<string, int>("XI", 11));
            _data.Add(new Tuple<string, int>("XII", 12));
            _data.Add(new Tuple<string, int>("XIII", 13));
            _data.Add(new Tuple<string, int>("XIV", 14));
            _data.Add(new Tuple<string, int>("XV", 15));
            _data.Add(new Tuple<string, int>("XVI", 16));
            _data.Add(new Tuple<string, int>("XVII", 17));
            _data.Add(new Tuple<string, int>("XVIII", 18));
            _data.Add(new Tuple<string, int>("XIX", 19));
            _data.Add(new Tuple<string, int>("XX", 20));
            _data.Add(new Tuple<string, int>("L", 50));
            _data.Add(new Tuple<string, int>("LV", 55));
            _data.Add(new Tuple<string, int>("LX", 60));
            _data.Add(new Tuple<string, int>("LXVII", 67));
            _data.Add(new Tuple<string, int>("LXXIX", 79));
            _data.Add(new Tuple<string, int>("LXXXVIII", 88));
            _data.Add(new Tuple<string, int>("XCIX", 99));
            _data.Add(new Tuple<string, int>("CIV", 104));
            _data.Add(new Tuple<string, int>("CXII", 112));
            _data.Add(new Tuple<string, int>("CCXXII", 222));
            _data.Add(new Tuple<string, int>("CDXXII", 422));
            _data.Add(new Tuple<string, int>("DXXXVII", 537));
            _data.Add(new Tuple<string, int>("DCXXIV", 624));
            _data.Add(new Tuple<string, int>("DCCC", 800));
            _data.Add(new Tuple<string, int>("CM", 900));
            _data.Add(new Tuple<string, int>("M", 1000));
            _data.Add(new Tuple<string, int>("MCDXLIV", 1444));
            _data.Add(new Tuple<string, int>("MMMMCDXLIV", 4444));
          
        }
        
        [Test]
        public void TestIntegerToRoman()
        {
            var p = new IntegerToRoman();
            foreach(var item in _data)
            {
                Console.WriteLine("input:{0}", item.Item2);
                var res = p.Solution2(item.Item2);

                Console.WriteLine("output:{0}", res);
                Console.WriteLine();
                Assert.AreEqual(item.Item1, res);
            }
        }
    }
}
