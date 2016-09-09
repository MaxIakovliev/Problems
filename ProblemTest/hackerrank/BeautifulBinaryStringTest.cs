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
    public class BeautifulBinaryStringTest
    {
        [Test]
        public void BeautifulBinaryStringSolution1Test()
        {
            var d=new List<Tuple<string,int>>();
            //d.Add(new Tuple<string, int>("0101010", 2));
            //d.Add(new Tuple<string, int>("01100", 0));
            //d.Add(new Tuple<string, int>("0100101010", 3));
            //d.Add(new Tuple<string, int>("0100101010010", 4));
            //d.Add(new Tuple<string, int>("0100010", 2));
            //d.Add(new Tuple<string, int>("", 0));
            //d.Add(new Tuple<string, int>("111111111111", 0));
            //d.Add(new Tuple<string, int>("01010111111", 1));
            d.Add(new Tuple<string, int>("01001001011101", 3));
            var p = new BeautifulBinaryString();
            foreach(var item in d)
            {
                Console.WriteLine(item.Item1);
                int res = p.Solution1(item.Item1);
                Assert.AreEqual(item.Item2, res);
            }
        }
    }
}
