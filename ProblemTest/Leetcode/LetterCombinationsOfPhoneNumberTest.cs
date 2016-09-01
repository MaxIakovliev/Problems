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
    public class LetterCombinationsOfPhoneNumberTest
    {
        private IList<string> _data;

        [SetUp]
        public void Init()
        {
            _data = new List<string>();
            var a=new string[]{"a","b","c"};
            var b=new string[]{"d","e","f"};
            var c=new string[]{"g","h","i"};
            for (int i = 0; i < a.Length; i++)
                for (int j = 0; j < b.Length; j++)
                    for (int k = 0; k < c.Length; k++)
                        _data.Add(a[i] + b[j] + c[k]);


        }
        [Test]
        public void TestLetterCombinationsOfPhoneNumberSolution1()
        {
            var p = new LetterCombinationsOfPhoneNumber();
            var res=p.Solution1("234");
           foreach(var i in res)
            Console.Write("{0} ", i);

           foreach (var item in _data)
           {
               var result = res.Where(c => c == item).First<string>();
               Assert.AreEqual(item, result);
           }
        }
    }
}
