using Problems.Arrays;
using Problems.BinarySearch;
using Problems.DynamicProgramming;
using Problems.hackerrank.Strings;
using Problems.Leetcode;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    class Program
    {
        static void Main(string[] args) 
        {
            var p = new BearandSteadyGene();

            p.Solution2(File.ReadAllText("BearandSteadyGene.txt"));

            

        }
    }
}
