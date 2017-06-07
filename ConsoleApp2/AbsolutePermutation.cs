using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/absolute-permutation
    /// </summary>
    public class AbsolutePermutation
    {
        static void Algorithm()
        {
            int[,] a = new int[,] {
                //{ 98280, 84 },
                //{ 52136, 931 },
                //{ 96448, 63072 },
                //{ 65536, 1024 },
                //{ 11095, 1585 },
                //{ 69660, 1620 },
                //{ 16464, 1176 },
                //{ 45238, 0 },
                //{ 91758, 1119 },
                { 100, 2 } };

            for (int x = 0; x < 1; x++)
            {
                int n = a[x, 0];
                int k = a[x, 1];

                int[] result = new int[n];

                if (k == 0)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        result[i - 1] = i;
                    }
                    Console.WriteLine(string.Join(" ", result));
                }
                else
                {
                    if (n % 2 == 1 || n % k != 0 || (n / k) % 2 != 0 || k > n / 2) Console.WriteLine("-1");
                    else
                    {
                        for (int i = 1; i <= n; i += 2 * k)
                        {
                            for (int j = i; j < i + 2 * k; j++)
                            {
                                result[j - 1] = j - i < k ? j + k : j - k;
                            }
                        }
                        Console.WriteLine(string.Join(" ", result));
                    }
                }
            }
        }
    }
}
