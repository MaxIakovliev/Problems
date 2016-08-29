using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Leetcode
{
    public class ZigZagConversion
    {
        public string Solution1(string s, int nRows)
        {
            var result = new List<char[]>();
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
                        offset++;
                    }
                    i += j;
                    isSolid = false;
                }
                else
                {
                    i++;
                    if (i >= s.Length)
                     break;

                    arr[--offset] = s[i];
                    
                }
                result.Add(arr);

                if (offset == 0)
                    isSolid = true;
            }
            var sb = new StringBuilder();
            for(i=0; i<result.Count; i++)
                for(int j=0; j<nRows; j++)
                {
                    if(result[i][j]!=default(char))
                    {
                        sb.Append(result[i][j]);
                    }
                }
            return sb.ToString();
        }
       
    }
}
