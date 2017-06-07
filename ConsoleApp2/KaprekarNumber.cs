using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/kaprekar-numbers
    /// </summary>
    public class KaprekarNumber
    {
        static void Algorithm()
        {
            long p = 1;
            long q = 99999;
            List<string> result = new List<string>();

            for (long i = p; i <= q; i++)
            {
                long square = i * i;
                int iLength = i.ToString().Length;
                string squareStr = square.ToString();

                if (squareStr.Length == iLength && square == i)
                {
                    result.Add(i.ToString());
                    continue;
                }
                else if (squareStr.Length > iLength)
                {
                    long d1 = long.Parse(squareStr.Substring(0, iLength));
                    long r1 = long.Parse(squareStr.Substring(iLength, squareStr.Length - iLength));

                    long d2 = long.Parse(squareStr.Substring(squareStr.Length - iLength, iLength));
                    long r2 = long.Parse(squareStr.Substring(0, squareStr.Length - iLength));

                    if ((d1 + r1 == i && r1 > 0)
                      || (d2 + r2 == i && r2 > 0))
                    {
                        result.Add(i.ToString());
                        continue;
                    }
                }
            }

            Console.WriteLine(result.Aggregate((a, b) => a + " " + b));
        }
    }
}
