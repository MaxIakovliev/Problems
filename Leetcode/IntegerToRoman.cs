using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Leetcode
{
    public class IntegerToRoman
    {
        public string Convert(int num)
        {
            var sb = new StringBuilder();
            var dict = new Dictionary<int, string>(){
            {1,"I"},
            {5,"V"},
            {10,"X"},
            {50,"L"},
            {100,"C"},
            {500, "D"},
            {1000, "M"}
            };
            int len = 0;
            var tmp = num;
            var parts = new List<int>();
            while (tmp > 0)
            {
                var pow = (int)Math.Pow(10, (len + 1));
                var t = tmp % pow;
                parts.Add(t);
                tmp = tmp - tmp % pow;

                len++;
            }

            for (int i = parts.Count() - 1; i >= 0; i--)
            {
                if (parts[i] < 5)
                {
                    if (parts[i] <= 3)
                    {
                        for (int j = 0; j < parts[i]; j++)
                            sb.Append(dict[1]);
                    }
                    else
                    {
                        sb.Append(dict[1]);
                        sb.Append(dict[5]);
                    }

                }
                else if (parts[i] == 5)
                {
                    sb.Append(dict[5]);
                }
                else if (parts[i] > 5 && parts[i] < 10)
                {
                    if (parts[i] > 5 && parts[i] <= 5 + 3)
                    {
                        sb.Append(dict[5]);
                        for (int j = 0; j < parts[i] - 5; j++)
                            sb.Append(dict[1]);
                    }
                    else
                    {
                        for (int j = 0; j < parts[i] - 5 - 3; j++)
                            sb.Append(dict[1]);
                        sb.Append(dict[10]);
                    }
                }
                else if (parts[i] == 10)
                {
                    sb.Append(dict[10]);
                }
                else if(parts[i] > 10 && parts[i] <=30)
                {
                        for (int j = 0; j < parts[i]/10; j++)
                        {
                            sb.Append(dict[10]);
                        }

                }
                else if(parts[i]==40)
                {
                    sb.Append(dict[10]);
                    sb.Append(dict[50]);
                }
                else if (parts[i]==50)
                {
                    sb.Append(dict[50]);
                }
                else if (parts[i]>50 && parts[i]<=50+30)
                {
                    sb.Append(dict[50]);
                    for (int j = 5; j < (parts[i] / 10); j++)
                    {
                        sb.Append(dict[10]);
                    }
                }
                else if(parts[i]==90)
                {
                    sb.Append(dict[10]);
                    sb.Append(dict[100]);
                }
                else if(parts[i]==100)
                {
                    sb.Append(dict[100]);
                }
                else if(parts[i]>100 && parts[i]<=300)
                {
                    for (int j = 0; j < parts[i] / 100; j++)
                    {
                        sb.Append(dict[100]);
                    }
                }
                else if (parts[i] == 400)
                {
                    sb.Append(dict[100]);
                    sb.Append(dict[500]);
                }
                else if (parts[i] == 500)
                {
                    sb.Append(dict[500]);
                }
                else if(parts[i] > 500 && parts[i] <= 500+300)
                {
                    sb.Append(dict[500]);
                    for (int j = 5; j < parts[i] / 100; j++)
                    {
                        sb.Append(dict[100]);
                    }
                }
                else if (parts[i] == 900)
                {
                    sb.Append(dict[100]);
                    sb.Append(dict[1000]);
                }
                else if (parts[i] == 1000)
                {
                    sb.Append(dict[1000]);
                }
                else if (parts[i] > 1000 && parts[i]<=4000)
                {
                    for (int j = 0; j < parts[i] / 1000; j++)
                    {
                        sb.Append(dict[1000]);
                    }
                }
            }
            return sb.ToString();
        }

    }
}
