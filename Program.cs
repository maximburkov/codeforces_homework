using System;
using System.Linq;

namespace AlgoContest
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToCharArray();
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[s.Length];

            char prev = s[0];
            arr[0] = 1;

            for (int i = 1; i < s.Length; i++)
            {
                arr[i] = s[i] == prev ? arr[i - 1] + 1 : arr[i - 1];
                prev = s[i];
            }

            int left, right;
            for (int i = 0; i < n; i++)
            {
                var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
                left = buf[0] - 1;
                right = buf[1] - 1;
                Console.WriteLine(arr[right] - arr[left]);
            }
        }
    }
}
