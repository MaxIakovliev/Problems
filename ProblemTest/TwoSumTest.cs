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
    public class TwoSumTest
    {
        private List<Tuple<int[], int>> _inputData;

        private Random _rnd = new Random();
        [SetUp]
        public void Init()
        {

            _inputData = new List<Tuple<int[], int>>();
            int size = 3;
            for (int p = 0; p < 100; p++)
            {
                var arr = new int[size];
                for (int i = 0; i < size; i++)
                {
                    arr[i] = _rnd.Next(-10, 10);
                }
                int a, b;
                do
                {
                    a = _rnd.Next(0, size-1);
                    b = _rnd.Next(0, size-1);
                } while (a == b);

                int sum = arr[a] + arr[b];
                _inputData.Add(new Tuple<int[], int>(arr, sum));
            }
        }

        [Test]
        public void TestSolution1()
        {
            var p = new TwoSum();
            for (int i = 0; i < _inputData.Count(); i++)
            {
                PrintArray(_inputData[i].Item1);
                Console.WriteLine("target:{0}", _inputData[i].Item2);
                var result = p.Solution1(_inputData[i].Item1, _inputData[i].Item2);
                Console.WriteLine("{0}, {1}", result[0], result[1]);
                Assert.True(result[0] != -1);
                Assert.True(result[1] != -1);
                Assert.True(result[1] != result[0]);
                Assert.AreEqual(_inputData[i].Item1[result[0]] + _inputData[i].Item1[result[1]], _inputData[i].Item2);
            }
        }

        private void PrintArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write("{0} ", a[i]);

            Console.WriteLine();
        }

    }
}
