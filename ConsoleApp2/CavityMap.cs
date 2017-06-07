using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/cavity-map
    /// </summary>
    public class CavityMap
    {
        static void Algorithm()
        {
            string[] input = new string[]
            {
                "1112",
                "1912",
                "1892",
                "1234"
            };

            char[][] grid = new char[4][];

            for (var i = 0; i < 4; i++)
            {
                grid[i] = input[i].ToCharArray();
            }

            for (int i = 1; i < 3; i++)
            {
                for (int j = 1; j < grid[i].Length - 1; j++)
                {
                    var adjacents = new char[]{
                        grid[i][j],
                        grid[i][j - 1],
                        grid[i][j + 1],
                        grid[i - 1][j],
                        grid[i + 1][j]
                    };

                    if (adjacents.Max() == grid[i][j] && adjacents.Count(x => x == grid[i][j]) == 1)
                    {
                        grid[i][j] = 'X';
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(string.Join("", grid[i]));
            }

            Console.ReadLine();
        }
    }
}
