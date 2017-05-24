using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class Algorithms
    {

        /// <summary>
        /// https://www.hackerrank.com/challenges/the-birthday-bar?h_r=next-challenge&h_v=zen
        /// </summary>
        /// <param name="n"></param>
        /// <param name="s"></param>
        /// <param name="d"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        static int algo4(int n, int[] s, int d, int m)
        {
            int totalNumberOfWays = 0;

            if (s.Length < m) return totalNumberOfWays;

            for (var i = 0; i < s.Length - m + 1; i++)
            {
                int sum = 0;
                for (var j = 0; j < m; j++)
                {
                    sum += s[i + j];
                }
                if (sum == d)
                    totalNumberOfWays++;
            }

            return totalNumberOfWays;
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/between-two-sets?h_r=next-challenge&h_v=zen
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int algo3(int[] a, int[] b)
        {
            int totalX = 0;
            int maxA = a.Max();
            int minB = b.Min();

            for (var i = maxA; i <= minB; i += maxA)
            {
                bool found = true;
                for (var j = 0; j < a.Length; j++)
                {
                    if (i % a[j] != 0)
                    {
                        found = false;
                        break;
                    }
                }

                if (!found)
                    continue;

                for (var j = 0; j < b.Length; j++)
                {
                    if (b[j] % i != 0)
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                {
                    totalX++;
                }
            }

            return totalX;
        }

        static void Algo2()
        {
            var s = "1817 4000 8417 190";

            string[] tokens_x1 = s.Split(' ');
            float x1 = Convert.ToInt32(tokens_x1[0]);
            float v1 = Convert.ToInt32(tokens_x1[1]);
            float x2 = Convert.ToInt32(tokens_x1[2]);
            float v2 = Convert.ToInt32(tokens_x1[3]);

            Console.WriteLine(x1);
            Console.WriteLine(v1);
            Console.WriteLine(x2);
            Console.WriteLine(v2);

            Console.WriteLine((x2 - x1) / (v1 - v2));
        }

        static void Algo1()
        {
            string[] lines = File.ReadAllLines("data.txt");

            using (var stream = new StreamReader(new FileStream("data.txt", FileMode.Open)))
            {
                string[] tokens_s = stream.ReadLine().Split(' ');
                int s = Convert.ToInt32(tokens_s[0]);
                int t = Convert.ToInt32(tokens_s[1]);
                string[] tokens_a = stream.ReadLine().Split(' ');
                int a = Convert.ToInt32(tokens_a[0]);
                int b = Convert.ToInt32(tokens_a[1]);
                string[] tokens_m = stream.ReadLine().Split(' ');
                int m = Convert.ToInt32(tokens_m[0]);
                int n = Convert.ToInt32(tokens_m[1]);
                string[] apple_temp = stream.ReadLine().Split(' ');
                int[] apple = Array.ConvertAll(apple_temp, Int32.Parse);
                string[] orange_temp = stream.ReadLine().Split(' ');
                int[] orange = Array.ConvertAll(orange_temp, Int32.Parse);

                int appleInHouse = 0;
                int orangeInHouse = 0;

                long distanceStoA = s - a;
                long distanceBtoT = t - b;

                long distanceBtoS = s - b;
                long distanceTtoA = t - a;

                for (var i = 0; i < m; i++)
                {
                    if (apple[i] >= distanceStoA && apple[i] <= distanceTtoA)
                    {
                        appleInHouse++;
                    }
                }

                for (var i = 0; i < n; i++)
                {
                    if (orange[i] <= distanceBtoT && orange[i] >= distanceBtoS)
                    {
                        orangeInHouse++;
                    }
                }

                Console.WriteLine(appleInHouse);
                Console.WriteLine(orangeInHouse);
            }
        }
    }
}
