﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Leetcode
{
    public class RomanToInt
    {
        public int Convert(string s)
        {
            int result = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                switch (s[i])
                {
                    case 'I':
                        result += (result >= 5 ? -1 : 1);
                        break;
                    case 'V':
                        result += 5;
                        break;
                    case 'X':
                        result += 10 * (result >= 50 ? -1 : 1);
                        break;
                    case 'L':
                        result += 50;
                        break;
                    case 'C':
                        result += 100 * (result >= 500 ? -1 : 1);
                        break;
                    case 'D':
                        result += 500;
                        break;
                    case 'M':
                        result += 1000;
                        break;

                }
            }
            return result;
        }
    }
}
