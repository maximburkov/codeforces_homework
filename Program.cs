using System;
using System.Linq;
using System.Collections.Generic;

namespace AlgoContest
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] res = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < n; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        res[i, j] = buf[j];
                    }
                    else
                    {
                        if (i == 0)
                        {
                            res[i, j] = res[i, j - 1] + buf[j];
                        }
                        else if (j == 0)
                        {
                            res[i, j] = res[i - 1, j] + buf[j];
                        }
                        else
                        {
                            res[i, j] = Math.Max(res[i - 1, j], res[i, j - 1]) + buf[j];
                        }
                    }
                }
            }

            Console.WriteLine(res[n - 1, n -1]);
        }
    }
}

