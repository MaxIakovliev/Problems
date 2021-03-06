﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Arrays
{
    /// <summary>
    ///  Best Time to Buy and Sell Stock
    ///  Say you have an array for which the ith element is the price of a given stock on day i.
    ///  If you were only permitted to complete at most one transaction (ie, buy one and sell one share of the 
    ///  stock), design an algorithm to find the maximum profit.
    ///  URL:https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
    /// </summary>
    class BestTimeToBuyAndSellStock
    {
        /// <summary>
        /// Complexity O(n*n)
        /// Simple and dirty solution
        /// </summary>
        /// <param name="a">input array</param>
        /// <param name="buy"> index of buy price</param>
        /// <param name="sell">index pf sell price</param>
        public int Solve(int[] a, ref int buy, ref int sell)
        {
            buy = sell = -1;
            int maxProfit = -1;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    int tmp = a[j] - a[i];
                    if (tmp > 0 && tmp > maxProfit)
                    {
                        maxProfit = tmp;
                        buy = i;
                        sell = j;
                    }
                }
            }
            return maxProfit;
        }

        /// <summary>
        /// Complexity O(n)
        /// Example of good optimization made based on previous solution
        /// </summary>
        /// <param name="a">input array</param>
        /// <param name="buy"> index of buy price</param>
        /// <param name="sell">index pf sell price</param>
        public int Solve2(int[] a, ref int buy, ref int sell)
        {
            buy = 0;
            var minPrice = a[buy];
            var maxProfit = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] - minPrice > maxProfit)
                {
                    maxProfit = a[i] - minPrice;
                    sell = i;
                }
                if (minPrice > a[i])
                {
                    minPrice = a[i];
                    buy = i;
                }
            }
            return maxProfit;
        }


        //HOW TO TEST
        //static void Main(string[] args)
        //{
        //    var bs = new BestTimeToBuyAndSellStock();
        //    int buy, sell;
        //    buy = sell = -1;
        //    var data = new int[] { 7, 1, 5, 3, 6, 4 };
        //    var profit = bs.Solve2(data, ref buy, ref sell);
        //    Console.WriteLine("Case 1");
        //    data.ToList().ForEach(i => Console.Write("{0} ", i));

        //    if (buy != sell)
        //        Console.WriteLine("\n{0}-{1}={2}", data[sell], data[buy], profit);
        //    else
        //        Console.WriteLine("\nNo Operations, 0 profit");



        //    data = new int[] { 7, 6, 4, 3, 1 };
        //    profit = bs.Solve2(data, ref buy, ref sell);
        //    Console.WriteLine("\nCase 2");
        //    data.ToList().ForEach(i => Console.Write("{0} ", i));

        //    if (buy != sell)
        //        Console.WriteLine("\n{0}-{1}={2}", data[sell], data[buy], profit);
        //    else
        //        Console.WriteLine("\nNo Operations, 0 profit");

        //}
    }
}
