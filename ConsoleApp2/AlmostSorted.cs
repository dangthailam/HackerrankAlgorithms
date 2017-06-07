using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/almost-sorted
    /// </summary>
    public class AlmostSorted
    {
        static void Algorithm()
        {
            //List<int> d = "43 65 1 98 99 101".Split(' ').Select(int.Parse).ToList();

            List<int> d = "1 5 4 3 2 6".Split(' ').Select(int.Parse).ToList();

            d.Add(1000001);

            d.Insert(0, -1);

            int inversion = 0, reversion = 0;
            List<int> changePoints = new List<int>();

            for (int d_i = 1; d_i < d.Count - 1; d_i++)
            {
                if (d[d_i] > d[d_i + 1] && d[d_i] > d[d_i - 1])
                {
                    changePoints.Add(d_i);
                    inversion++;
                }
                else if (d[d_i] < d[d_i + 1] && d[d_i] < d[d_i - 1])
                {
                    changePoints.Add(d_i);
                    reversion++;
                }
            }

            int l = changePoints.Min(), r = changePoints.Max();

            if (inversion == 0 && reversion == 0)
            {
                Console.WriteLine("yes");
                return;
            }

            bool sorted = true;

            if ((inversion == 2 && reversion == 2) || (inversion == 1 && reversion == 1 && l == r - 1)) //swap
            {
                int temp = d[l];
                d[l] = d[r];
                d[r] = temp;

                for (int d_i = 0; d_i < d.Count - 1; d_i++)
                {
                    if (d[d_i] > d[d_i + 1])
                    {
                        sorted = false;
                        break;
                    }
                }

                if (sorted) Console.WriteLine(string.Format("yes\nswap {0} {1}", l, r));
                else Console.WriteLine("no");
            }
            else if (inversion == 1 && reversion == 1 && l < r - 1) //reverse
            {
                for (var i = l; i < (r + l) / 2 + 1; i++)
                {
                    int temp = d[i];
                    d[i] = d[r + l - i];
                    d[r + l - i] = temp;
                }

                for (int d_i = 0; d_i < d.Count - 1; d_i++)
                {
                    if (d[d_i] > d[d_i + 1])
                    {
                        sorted = false;
                        break;
                    }
                }

                if (sorted) Console.WriteLine(string.Format("yes\nreverse {0} {1}", l, r));
                else Console.WriteLine("no");
            }
            else Console.WriteLine("no");
        }
    }
}
