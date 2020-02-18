using System;
using System.Linq;
using System.Collections.Generic;

namespace AlgoContest
{
    class Program
    {
        static int GetHappy(int[,] arr, int fistIndex, int secondIndex) => arr[fistIndex, secondIndex] + arr[secondIndex, fistIndex];

        static int GetHappyForAll(int[,] arr, int[] pos) => GetHappy(arr, pos[0], pos[1]) + GetHappy(arr, pos[2], pos[3]) * 2
            + GetHappy(arr, pos[1], pos[2]) + GetHappy(arr, pos[3], pos[4]) * 2;

        static void GetMax(int[,] arr, ref int max, List<int> added, List<int> left)
        {
            if(added.Count == 5)
            {
                int currentMax = GetHappyForAll(arr, added.ToArray());
                if (currentMax > max)
                    max = currentMax;

                return;
            }
            foreach(var item in left)
            {
                var newAdded = added.ToList();
                newAdded.Add(item);
                var newLeft = left.ToList();
                newLeft.Remove(item);
                GetMax(arr, ref max, newAdded, newLeft);
            }
        }


        static void Main(string[] args)
        {
            int[,] arr = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = buf[j];
                }
            }

            int max = 0;

            GetMax(arr, ref max, new List<int>(), new List<int> { 0, 1, 2, 3, 4 });
            Console.WriteLine(max);
        }
    }
}

