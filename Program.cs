using System;
using System.Collections.Specialized;
using System.Linq;

namespace AlgoContest
{
    class Program
    {
        private static int K;
        private static int N;
        private static int Total;
        static bool IsOk(int [,] a, int row, int col)
        {
            int i, j;
            for (i = 0; i < col; i++)
                if (a[row, i] == 1)
                    return false;

            for (i = 0; i < row; i++)
                if (a[i, col] == 1)
                    return false;

            for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
                if (a[i, j] == 1)
                    return false;

            for (i = row, j = col; j >= 0 && i < a.GetLength(0); i++, j--)
                if (a[i, j] == 1)
                    return false;

            return true;
        }

        static void AddOne(int [,] a, int count, int row, int col)
        {
            if (count == K)
            {
                Total++;
                if (col == 0)
                {
                    a[row - 1, N - 1] = 0;
                }
                else
                {
                    a[row, col - 1] = 0;
                }

                AddOne(a, count - 1, row, col);
                return;
            }

            if(row >= N || col >= N)
            {
                return;
            }

            if (IsOk(a, row, col))
            {
                a[row,col] = 1;

                if (col == N - 1)
                    AddOne(a, count + 1, row + 1, 0);
                else
                    AddOne(a, count + 1, row, col + 1);

                a[row,col] = 0;
            }
            else
            {
                if (col == N - 1)
                    AddOne(a, count, row + 1, 0);
                else
                    AddOne(a, count, row, col + 1);
            }
        }

        static void Main(string[] args)
        {
            var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
            N = buf[0];
            K = buf[1];

            int[,] a = new int[N,N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    AddOne(a, 0, i,j);
                }
            }

        }
    }
}
