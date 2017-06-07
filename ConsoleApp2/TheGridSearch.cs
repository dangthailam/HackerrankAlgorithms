using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/the-grid-search
    /// </summary>
    public static class TheGridSearch
    {
        static void Algorithm()
        {
            //DateTime dateTime = DateTime.Parse("00:00");

            //string[] G = new string[10]
            //{
            //    "7283455864",
            //    "6731158619",
            //    "8988242643",
            //    "3830589324",
            //    "2229505813",
            //    "5633845374",
            //    "6473530293",
            //    "7053106601",
            //    "0834282956",
            //    "4607924137"
            //};

            //string[] P = new string[3]
            //{
            //    "9505",
            //    "3845",
            //    "3530"
            //};

            //string[] G = new string[7]
            //{
            //    "111111111111111",
            //    "111111111111111",
            //    "111111111111111",
            //    "111111011111111",
            //    "111111111111111",
            //    "111111111111111",
            //    "101010101010101"
            //};

            //string[] P = new string[4]
            //{
            //    "11111",
            //    "11111",
            //    "11111",
            //    "11110"
            //};

            string[] G = new string[4]
            {
                "123456",
                "567890",
                "234567",
                "194729"
            };

            string[] P = new string[2]
            {
                "78",
                "67"
            };

            //string[] G = new string[4]
            //{
            //    "123456",
            //    "567890",
            //    "234567",
            //    "194729"
            //};

            //string[] P = new string[4]
            //{
            //   "1234",
            //   "5678",
            //   "2345",
            //   "4729"
            //};

            int[] idxArr = new int[P.Length];

            bool result = false;

            for (int G_i = 0; G_i <= G.Length - P.Length; G_i++)
            {
                int idx = G[G_i].IndexOf(P[0]);
                if (idx != -1)
                {
                    result = true;

                    for (int P_i = G_i + 1; P_i < G_i + P.Length; P_i++)
                    {
                        int newIdx = G[P_i].Substring(idx).IndexOf(P[P_i - G_i]);

                        if (newIdx == -1)
                        {
                            result = false;
                            break;
                        }

                        if (newIdx != 0)
                        {
                            for (int P_sub_i = P_i - 1; P_sub_i >= G_i; P_sub_i--)
                            {
                                if (G[P_sub_i].Substring(newIdx + idx).IndexOf(P[P_sub_i - G_i]) != 0)
                                {
                                    result = false;
                                    break;
                                }
                            }
                        }
                    }

                    if (result)
                        break;
                }
            }

            Console.WriteLine(result);
        }
    }
}
