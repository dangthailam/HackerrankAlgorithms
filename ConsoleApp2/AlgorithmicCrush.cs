using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/crush
    /// </summary>
    public class AlgorithmicCrush
    {

        /*
            for each operation: a b k
                mark the cumulation at a position, so that till the end, we can sum up to that position
                for (b + 1) position, we need to substract k, because at this operation, b + 1 won't be cumulated.
             
            example:
                input:
                    5 3
                    1 2 100
                    2 5 100
                    3 4 100
                
                explanation:
                    
                    arr[1]  arr[2]  arr[3]  arr[4]  arr[5]
      operation 0   0       0       0       0       0
      operation 1   100     0       -100    0       0
      operation 2   0       100     0       0       0                  // (b + 1) is out of index => do nothing
      operation 3   0       0       100     0       -100

      final result  100     200     200     200     100

            => max = 200
             
             BE CAREFUL, VARIABLE MUST BE LONG TYPED (NOT INT)

             */
        static void Algorithm()
        {
            long x = 0, max = 0;
            using (var sr = new StreamReader("AlgorithmicCrush.txt"))
            {
                int[] firstLine = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int N = firstLine[0];
                int M = firstLine[1];

                long[] arr = Enumerable.Repeat<long>(0, (int)(N + 1)).ToArray();

                for (long M_i = 0; M_i < M; M_i++)
                {
                    long[] line = sr.ReadLine().Split(' ').Select(long.Parse).ToArray();
                    long a = line[0];
                    long b = line[1];
                    long k = line[2];

                    arr[a] += k;
                    if (b + 1 <= N) arr[b + 1] -= k;
                }

                for (int i = 1; i <= N; i++)
                {
                    x += arr[i];
                    if (x > max) max = x;
                }

                Console.WriteLine(max);
            }
        }
    }
}
