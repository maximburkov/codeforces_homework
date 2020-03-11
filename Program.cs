using System;
using System.Linq;

namespace AlgoContest
{
    class Program
    {
        static void Main(string[] args)
        {
            var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = buf[0];
            int b = buf[1];

            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var prices = new int[n/2 - 1];

            int odd = 0;
            int even = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                    odd++;
                else
                    even++;

                if(i %  2 != 0) //if even
                {
                    if(odd == even)
                    {
                        if(i != n - 1)
                        {
                            prices[(i + 1) / 2 - 1] = Math.Abs(arr[i + 1] - arr[i]);
                        }
                    }
                    else
                    {
                        if (i != n - 1)
                        {
                            prices[(i + 1) / 2 - 1] = int.MaxValue;
                        }
                    }
                }         
            }

            Array.Sort(prices);
            int count = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                b -= prices[i];

                if (b >= 0)
                    count++;

                if (b <= 0)
                    break;
            }

            Console.WriteLine(count);
        }
    }
}
