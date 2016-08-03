using Problems.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            var bs = new BestTimeToBuyAndSellStock();
            int buy, sell;
            buy = sell = -1;
            var data = new int[] { 7, 1, 5, 3, 6, 4 };
            var profit=bs.Solve2(data, ref buy, ref sell);
            Console.WriteLine("Case 1");
            data.ToList().ForEach(i => Console.Write("{0} ",i));

            if (buy !=sell)
                Console.WriteLine("\n{0}-{1}={2}", data[sell], data[buy], profit);
            else
                Console.WriteLine("\nNo Operations, 0 profit");



            data = new int[] { 7, 6, 4, 3, 1 };
            profit=bs.Solve2(data, ref buy, ref sell);
            Console.WriteLine("\nCase 2");
            data.ToList().ForEach(i => Console.Write("{0} ", i));

            if (buy != sell)
                Console.WriteLine("\n{0}-{1}={2}", data[sell], data[buy], profit);
            else
                Console.WriteLine("\nNo Operations, 0 profit");
        
        }
    }
}
