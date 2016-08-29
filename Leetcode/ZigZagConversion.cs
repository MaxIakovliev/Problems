using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Leetcode
{
/* Description of Zig Zag pattern
 * n=numRows
 * Δ=2n-2    1                           2n-1                         4n-3
 * Δ=        2                     2n-2  2n                    4n-4   4n-2
 * Δ=        3               2n-3        2n+1              4n-5       .
 * Δ=        .           .               .               .            .
 * Δ=        .       n+2                 .           3n               .
 * Δ=        n-1 n+1                     3n-3    3n-1                 5n-5
 * Δ=2n-2    n                           3n-2                         5n-4
*/

    /// <summary>
    /// https://leetcode.com/problems/zigzag-conversion/
    /// </summary>
    public class ZigZagConversion
    {
        public string Solution1(string s, int nRows, out List<char[]> result)
        {
            result = new List<char[]>();
            if (nRows == 1) return s;
            int i = 0;
            int offset = 0;
            bool isSolid = true;
            while (i<s.Length)
            {
                var arr = new char[nRows];
                if(isSolid)
                {
                    int j=0;
                    while(j<nRows && i+j<s.Length )
                    {
                        arr[j] = s[i + j];
                        j++;
                    }
                    offset = nRows - 1;
                    i = i + j;
                    isSolid = false;
                }
                else
                {
                    if (i >= s.Length)
                     break;

                    arr[--offset] = s[i++];
                    
                }
                result.Add(arr);

                if (offset == 1)
                    isSolid = true;
            }
            var sb = new StringBuilder();
            for(i=0; i<nRows; i++)
                for (int j = 0; j < result.Count; j++)
                {
                    if(result[j][i]!=default(char))
                    {
                        sb.Append(result[j][i]);
                    }
                }
            return sb.ToString();
        }
       
    }
}
