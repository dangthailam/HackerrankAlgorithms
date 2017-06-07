using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/encryption
    /// </summary>
    public class Encryption
    {
        static void Algorithm()
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
    }
}
