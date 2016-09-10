using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Common
    {

        public int IndexOf(StringBuilder sb, string q)
        {
            if (string.IsNullOrEmpty(q)) return -1;
            for (int i = 0; i <= sb.Length - q.Length + 1; i++)
            {
                if (sb[i] == q[0])
                {
                    bool match = true;
                    for (int j = i; j < i + q.Length; j++)
                    {

                        if (j >= sb.Length || sb[j] != q[j - i])
                        {
                            match = false;
                            //i++;
                            break;
                        }

                    }
                    if (match)
                        return i;
                }
            }
            return -1;
        }

    }
}
