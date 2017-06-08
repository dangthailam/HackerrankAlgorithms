using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ConsoleApp1
{
    class Range
    {
        public int A { get; set; }
        public int B { get; set; }
        public int Sum { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            

            Console.ReadLine();
        }

        static void CheckAndSyncRanges(List<Range> ranges, int a, int b, int k)
        {
            foreach(var range in ranges)
            {
                if(range.A < a && range.B < b)
                {

                }
                else if(range.A > a && range.B < b)
                {

                }
                else if(range.A < a && range.B > b)
                {

                }
                else
                {

                }
            }
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