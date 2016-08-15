using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.DynamicProgramming
{
    /// <summary>
    /// https://www.youtube.com/watch?v=GafjS0FfAC0
    /// </summary>
    class CoinChange
    {

        public int Solution1(int[] coins, int val)
        {
            var results = new List<int>();
            for (int i = 0; i < val; i++)
            {
                results.Add(GetMin(coins, i, results));
            }
            return results[results.Count - 1];
        }

        private int GetMin(int[] coins, int val, List<int> dict)
        {
            var result = new List<int>();
            for (int i = 0; i < coins.Length; i++)
            {
                if (coins[i] <= val)
                {
                    var tmp = val - coins[i];
                    if (tmp < dict.Count)
                        result.Add(dict[tmp]);
                    else
                        result.Add(val - coins[i]);
                }
                else
                    break;
            }
            int min = result[0];
            for(int i=1; i<result.Count(); i++)
            {
                if (min > result[i])
                    min = result[i];
            }
            return min + 1;
        }
    }
}
