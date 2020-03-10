using System;
using System.Linq;

namespace AlgoContest
{
    class Program
    {
        private static int _count = 0;

        static void Solve(int sum, int max)
        {
            if (sum == 0)
            {
                _count++;
                return;
            }
            for (int i = max; i >= 1; i--)
            {
                if (i <= sum)
                {
                    Solve(sum - i, i);
                }
            }
        }

        static void Main(string[] args)
        {
            var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = buf[0];
            int m = buf[1];

            Solve(n, m);

            Console.WriteLine(_count);
        }
    }
}
