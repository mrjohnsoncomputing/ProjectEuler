﻿using Helper;
using System;

namespace ProjectEuler
{
    class Problem005
    {
        internal static int Solve()
        {
            int seed = 20;
            bool found = false;
            int i = seed * (seed - 1);
            while (!found)
            {
                if (DividesByEach(i, seed))
                {
                    found = true;
                }
                else
                {
                    i += seed;
                }
            }
            return i;
        }

        private static bool DividesByEach(int number, int seed) 
        {
            for (int i = 2; i < seed; i++)
            {
                if (number % i != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
