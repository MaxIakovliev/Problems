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
    public class PalindromeIndexTest
    {
        [Test]
        public void PalindromeIndexSolution1Test()
        {
            var p = new PalindromeIndex();

            var res=p.Solution1(new List<string>() { "hgygsvlfcwnswtuhmyaljkqlqjjqlqkjlaymhutwsnwcwflvsgygh" });
            Assert.AreEqual(44, res[0]);


        }
    }
}
