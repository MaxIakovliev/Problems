using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Leetcode
{
    public class StringToInteger
    {
        public int AtoI(string s)
        {
            if (string.IsNullOrEmpty(s))
                return default(int);
            int result = 0;
            bool negative = false;
            int counter = 0;
            bool started = false;
            bool signFound = false;
            try
            {
                checked
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i] >= '0' && s[i] <= '9')
                        {
                            if (negative)
                                result = (result * 10 - (s[i] - '0'));
                            else
                                result = (result * 10 + (s[i] - '0'));

                            counter++;
                            started = true;

                        }
                        else if ((s[i] == '-' && !signFound) || (s[i] == '+' && !signFound))
                        {
                            if (s[i] == '-')
                            {
                                negative = true;
                                started = true;
                            }
                            else if (s[i] == '+')
                                started = true;

                            signFound = true;
                            continue;
                        }
                        else if (s[i] == ' ' && !started)
                            continue;
                        else
                            return result;

                    }
                    if (counter == 1)
                        result = result % 10;
                }
            }
            catch
            {
                if (result > 0)
                    return Int32.MaxValue;
                else
                    return Int32.MinValue;
            }
            return result;
        }

        /// <summary>
        /// optimized for speed 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int AtoI2(string s)
        {
            if (string.IsNullOrEmpty(s))
                return default(int);
            long result = 0;
            bool negative = false;
            int counter = 0;
            bool started = false;
            bool signFound = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                {
                    if (negative)
                    {
                        if ((result * 10 - (s[i] - '0')) < Int32.MinValue)
                            return Int32.MinValue;
                        else
                            result = (result * 10 - (s[i] - '0'));
                    }
                    else
                    {
                        if ((result * 10 + (s[i] - '0')) > Int32.MaxValue)
                            return Int32.MaxValue;
                        else
                            result = (result * 10 + (s[i] - '0'));
                    }

                    counter++;
                    started = true;

                }
                else if ((s[i] == '-' && !signFound) || (s[i] == '+' && !signFound))
                {
                    if (s[i] == '-')
                    {
                        negative = true;
                        started = true;
                    }
                    else if (s[i] == '+')
                        started = true;

                    signFound = true;
                    continue;
                }
                else if (s[i] == ' ' && !started)
                    continue;
                else
                    return (int)result;

            }
            if (counter == 1)
                result = result % 10;

            return (int)result;
        }
    }
}
