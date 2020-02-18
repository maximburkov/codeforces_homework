using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace AlgoContest
{
    class Program
    {
        static int GetHappy(int[,] arr, int fistIndex, int secondIndex) => arr[fistIndex, secondIndex] + arr[secondIndex, fistIndex];

        static int GetHappyForAll(int[,] arr, int[] pos) => GetHappy(arr, pos[0], pos[1]) + GetHappy(arr, pos[2], pos[3]) * 2
            + GetHappy(arr, pos[1], pos[2]) + GetHappy(arr, pos[3], pos[4]) * 2;

        static void GetMax(int[,] arr, ref int max, IImmutableList<int> added, IImmutableList<int> left)
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
                GetMax(arr, ref max, added.Add(item), left.Remove(item));
            }
        }


        static void Main(string[] args)
        {
            using (StreamReader r = new StreamReader("input.txt"))
            {
                int[,] arr = new int[5, 5];
                for (int i = 0; i < 5; i++)
                {
                    //var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    var buf = r.ReadLine().Split().Select(int.Parse).ToArray();
                    for (int j = 0; j < 5; j++)
                    {
                        arr[i, j] = buf[j];
                    }
                }

                int max = 0;

                GetMax(arr, ref max, new List<int>().ToImmutableList(), new List<int> { 0, 1, 2, 3, 4}.ToImmutableList());
                Console.WriteLine(max);
            }
        }
    }
}

