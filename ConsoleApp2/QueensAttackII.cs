using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/queens-attack-2
    /// </summary>
    public class QueensAttackII
    {
        static void Algorithm()
        {
            using (var sr = new StreamReader("input.txt"))
            {
                string[] tokens_n = sr.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);

                string[] tokens_rQueen = sr.ReadLine().Split(' ');
                int rQueen = Convert.ToInt32(tokens_rQueen[0]);
                int cQueen = Convert.ToInt32(tokens_rQueen[1]);

                int top = n - rQueen;
                int bottom = rQueen - 1;
                int left = cQueen - 1;
                int right = n - cQueen;
                int topLeft = Math.Min(top, left);
                int topRight = Math.Min(top, right);
                int bottomLeft = Math.Min(bottom, left);
                int bottomRight = Math.Min(bottom, right);

                for (int a0 = 0; a0 < k; a0++)
                {
                    string[] tokens_rObstacle = sr.ReadLine().Split(' ');
                    int rObstacle = Convert.ToInt32(tokens_rObstacle[0]);
                    int cObstacle = Convert.ToInt32(tokens_rObstacle[1]);

                    if (rObstacle == rQueen)
                    {
                        if (cObstacle < cQueen && left > cQueen - cObstacle - 1)
                        {
                            left = cQueen - cObstacle - 1;
                        }
                        else
                        {
                            right = cObstacle - cQueen - 1;
                        }
                    }
                    else if (cObstacle == cQueen)
                    {
                        if (rObstacle < rQueen && bottom > rQueen - rObstacle - 1)
                        {
                            bottom = rQueen - rObstacle - 1;
                        }
                        else
                        {
                            top = rObstacle - rQueen - 1;
                        }
                    }
                    else if (Math.Abs(rObstacle - rQueen) == Math.Abs(cObstacle - cQueen))
                    {
                        if (rObstacle < rQueen && cObstacle < cQueen && bottomLeft > Math.Abs(rObstacle - rQueen))
                        {
                            bottomLeft = Math.Abs(rObstacle - rQueen) - 1;
                        }
                        else if (rObstacle < rQueen && cObstacle > cQueen && bottomRight > Math.Abs(rObstacle - rQueen))
                        {
                            bottomRight = Math.Abs(rObstacle - rQueen) - 1;
                        }
                        else if (rObstacle > rQueen && cObstacle < cQueen && topLeft > Math.Abs(rObstacle - rQueen))
                        {
                            topLeft = Math.Abs(rObstacle - rQueen) - 1;
                        }
                        else if (topRight > Math.Abs(rObstacle - rQueen))
                        {
                            topRight = Math.Abs(rObstacle - rQueen) - 1;
                        }
                    }
                }

                int squares = top + bottom + left + right + topLeft + topRight + bottomLeft + bottomRight;

                Console.WriteLine(squares);
            }
        }
    }
}
