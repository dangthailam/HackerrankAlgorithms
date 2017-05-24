using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.ReadLine();
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/absolute-permutation
        /// </summary>
        static void AbsolutePermutation()
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

        /// <summary>
        /// https://www.hackerrank.com/challenges/encryption
        /// </summary>
        static void Encryption()
        {
            string s = "haveaniceday";
            int length = s.Length;
            int row = (int)Math.Floor(Math.Sqrt(length));
            int column = (int)Math.Ceiling(Math.Sqrt(length));

            if (row * column < length)
            {
                if (row < column) row = column;
                else column = row;
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (j * column + i < s.Length)
                        sb.Append(s[j * column + i]);
                }
                sb.Append(' ');
            }

            Console.WriteLine(sb);
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/kaprekar-numbers
        /// </summary>
        static void KaprekarNumber()
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

        /// <summary>
        /// https://www.hackerrank.com/challenges/non-divisible-subset
        /// </summary>
        static void NonDivisibleSubset()
        {
            int[] a = "1 2 3".Split(' ').Select(int.Parse).ToArray();

            int k = 8;

            int[] classes = new int[k];
            foreach (int a_i in a)
                classes[a_i % k]++;

            int sizeOfSPrime = 0;

            // three things to add:
            // 1. class 0 (max 1)
            // 2. class k/2 (if k is even; max 1)
            // 3. middle classes (max{# in class i, # in class k-i})
            if (classes[0] != 0)
                sizeOfSPrime++;

            if (k % 2 == 0 && classes[k / 2] != 0)
                sizeOfSPrime++;

            for (int i = 1; i < (k + 1) / 2; i++)
            {
                sizeOfSPrime += Math.Max(classes[i], classes[k - i]);
            }

            Console.WriteLine(sizeOfSPrime);
        }

        static void Algo5()
        {
            string s = "zzzzz";
            string t = "zzzzzzz";
            int k = 4;

            int shorterLength = t.Length <= s.Length ? t.Length : s.Length;
            int firstDifferentCharIndex = 0;
            int deleteOperations = 0, appendOperations = 0;

            if (s.Contains(t)) deleteOperations = s.Length - t.Length;
            else if (t.Contains(s)) appendOperations = t.Length - s.Length;
            else
            {
                for (var i = 0; i < shorterLength; i++)
                {
                    if (s[i] != t[i])
                    {
                        firstDifferentCharIndex = i;
                        break;
                    }
                }

                deleteOperations = s.Length - firstDifferentCharIndex;
                appendOperations = t.Length - firstDifferentCharIndex;
            }



            bool isPossible = (k >= deleteOperations + appendOperations && (k - deleteOperations - appendOperations) % 2 == 0)
                || (s.Equals(t) && k % 2 == 0)
                || k >= s.Length + t.Length;

            Console.WriteLine(isPossible ? "Yes" : "No");
        }

        static BigInteger GetFactorial(int n)
        {
            BigInteger test = 1;
            for (int i = 1; i <= n; i++)
            {
                test = BigInteger.Multiply(test, i);
            }
            return test;
        }
    }
}