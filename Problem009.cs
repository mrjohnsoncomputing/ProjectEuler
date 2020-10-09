using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem009
    {
        private static readonly int seed = 1000;
        internal static int limit = 900;
        internal static long answer = 0;
        public static long Solve()
        {
            List<int> squares = GenerateSquares();
            //Formatting.PrintList(squares);
            answer = SubtractFromSeed(squares);
            return answer;
        }

        internal static long SubtractFromSeed(List<int> squares)
        {
            for (int i = 1; i < seed; i++)
            {

                for (int j = 2; j < seed; j++)
                {
                    int leftover = seed - i - j;
                    int largest = new List<int>() { leftover, i, j }.Max();
                    if (squares.Contains(leftover*leftover) && squares.Contains(i * i) && squares.Contains(j * j)) {
                        if (i * i + j * j == largest * largest)
                        {
                            return i * j * leftover;
                        }
                    }
                }
            }
            return -1;
        }

        internal static List<int> GenerateSquares()
        {
            List<int> squares = new List<int>();
            int record = 0;
            for (int i = 2; i < limit; i++)
            {
                int square = i * i;
                record = square;
                squares.Add(square);
            }
            return squares;
        }
    }
}
