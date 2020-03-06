using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoContest
{
    class Program
    {
        static bool IsUnhappy = false;

        static bool CheckIsUnhappy(int[] head, int[] tail, List<int> permutations)
        {
            bool allBigger = true;
            bool allLess = true;

            for (int i = 0; i < permutations.Count; i++)
            {
                if (head[i] >= tail[permutations[i]])
                    allLess = false;

                if (head[i] <= tail[permutations[i]])
                    allBigger = false;


                if (!(allLess || allBigger))
                    return false;
            }

            return true;
        }

        static void Solve(List<int> added, List<int> left, int[] head, int[] tail, int n)
        {
            if (added.Count == n)
            {
                IsUnhappy = true;
                return;
            }

            foreach (var item in left)
            {
                var newAdded = added.ToList();
                newAdded.Add(item);
                var newLeft = left.ToList();
                newLeft.Remove(item);

                if (CheckIsUnhappy(head, tail, newAdded))
                {
                    Solve(newAdded, newLeft, head, tail, n);
                }
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var buf = Console.ReadLine().ToCharArray().Select(i => int.Parse(i.ToString())).ToArray();
            var head = buf.Take(n).ToArray();
            var tail = buf.Skip(n).ToArray();
            var added = new List<int>(n);
            var left = Enumerable.Range(0, n).ToList();

            Solve(added, left, head, tail, n);
            Console.WriteLine(IsUnhappy ? "YES" : "NO");
        }
    }
}
