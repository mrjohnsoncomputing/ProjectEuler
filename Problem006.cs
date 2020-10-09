using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    class Problem006
    {
        public static int Solve()
        {
            int seed = 100;
            int sum = SumOfTheSquares(seed);
            int sqr = SquareOfTheSum(seed);
            return sqr - sum;
        }

        private static int SumOfTheSquares(int range)
        {
            int sum = 0;
            for (int i = 1; i <= range; i++)
            {
                sum += i * i;
            }
            return sum;
        }

        private static int SquareOfTheSum(int range)
        {
            int sum = 0;
            for (int i = 1; i <= range; i++)
            {
                sum += i;
            }
            return sum * sum;
        }
    }
}
