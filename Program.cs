using System;
using System.Linq;

namespace AlgoContest
{
    class Program
    {
        private static int ColCount;
        private static int FloorCount;
        private static int[] LastsFromLeft;
        private static int[] LastsFromRight;
        private static int LastFloor = 0;

        static int GetDistance(bool isLeft, int floor, int total)
        {
            if (floor == LastFloor)
            {
                var res = total + (isLeft ? LastsFromLeft[floor] : LastsFromRight[floor]);
                return res;
            }
            else
            {
                if (isLeft)
                {
                    var toLeft = LastsFromLeft[floor] * 2 + 1;
                    var toRight = ColCount + 2;
                    return Math.Min(GetDistance(true, floor + 1, total + toLeft),
                        GetDistance(false, floor + 1, total + toRight));
                }
                else
                {
                    var toRight = LastsFromRight[floor] * 2 + 1;
                    var toLeft = ColCount + 2;
                    return Math.Min(GetDistance(true, floor + 1, total + toLeft),
                        GetDistance(false, floor + 1, total + toRight));
                }
            }
        }


        static void Main(string[] args)
        {
            //using(StreamReader r = new StreamReader("input.txt"))
            //{
            var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //var buf = r.ReadLine().Split().Select(int.Parse).ToArray();

            FloorCount = buf[0];
            ColCount = buf[1];
            LastsFromLeft = new int[FloorCount];
            LastsFromRight = new int[FloorCount];

            for (int i = 0; i < FloorCount; i++)
            {
                buf = Console.ReadLine().ToCharArray().Select(b => Convert.ToInt32(b) - 48).ToArray();
                //buf = r.ReadLine().ToCharArray().Select(b => Convert.ToInt32(b) - 48).ToArray();


                for (int j = 1; j <= ColCount; j++)
                {
                    if (buf[j] == 1)
                    {
                        LastsFromLeft[i] = j;
                    }

                    if (LastsFromRight[i] == 0 && buf[j] == 1)
                    {
                        LastsFromRight[i] = ColCount + 1 - j;
                    }
                }
            }

            for (int i = 0; i < FloorCount; i++)
            {
                if (LastsFromLeft[i] != 0)
                {
                    LastFloor = FloorCount - i - 1;
                    break;
                }
            }

            Array.Reverse(LastsFromLeft);
            Array.Reverse(LastsFromRight);

            var result = GetDistance(true, 0, 0);

            Console.WriteLine(result);

        }
    }
}
