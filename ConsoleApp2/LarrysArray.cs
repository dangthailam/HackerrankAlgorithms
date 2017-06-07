using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class LarrysArray
    {
        static void Algorithm()
        {
            string[] input = new string[]
            {
                "3 1 2",
                "1 3 4 2",
                "1 2 3 5 4",
                "1 8 2 4 3 7 6 5",
                "13 2 10 3 1 12 8 4 5 9 6 15 14 11 7"
            };

            for (var i = 0; i < input.Length; i++)
            {
                int[] A = input[i].Split(' ').Select(int.Parse).ToArray();

                double width = Math.Ceiling(Math.Sqrt(A.Length));

                int inversion = 0;

                for (int A_i = 0; A_i < A.Length; A_i++)
                {
                    for (int A_j = A_i + 1; A_j < A.Length; A_j++)
                    {
                        if (A[A_j] < A[A_i])
                        {
                            inversion++;
                        }
                    }
                }

                bool solvable = inversion % 2 == 0;

                Console.WriteLine(solvable ? "YES" : "NO");
            }
        }
    }
}
