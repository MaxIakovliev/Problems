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
    public class FunnyStringTest
    {
        [Test]
        public void FunnyStringSolution1Test()
        {
            var d = new List<Tuple<string, string>>();
            d.Add(new Tuple<string, string>("acxz", "Funny"));
            d.Add(new Tuple<string, string>("bcxz", "Not Funny"));
            var p=new FunnyString();
            for(int i=0; i<d.Count; i++)
            {
                var res = p.Solution1(new List<string>() { d[i].Item1 });
                Assert.AreEqual(d[i].Item2, res[0]);
            }
        }
    }
}
