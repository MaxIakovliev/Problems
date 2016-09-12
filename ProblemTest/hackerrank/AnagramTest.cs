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
    public class AnagramTest
    {
        [Test]
        public void AnagramSolution1Test()
        {
            var d = new List<Tuple<string, int>>();
            d.Add(new Tuple<string, int>("aaabbb", 3));
            d.Add(new Tuple<string, int>("ab", 1));
            d.Add(new Tuple<string, int>("abc", -1));
            d.Add(new Tuple<string, int>("mnop", 2));
            d.Add(new Tuple<string, int>("xyyx", 0));
            d.Add(new Tuple<string, int>("xaxbbbxx", 1));
            var p = new Anagram();
            foreach (var i in d)
            {
                Console.WriteLine("expected:"+ i.Item2);
                p.Solution1(new List<string>() { i.Item1 });
                Console.WriteLine();
            }
        }

    }
}
