using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    class Problem012
    {
        public static int Solve()
        {
            int seed = 7;
            TriangleNumbers tnums = new TriangleNumbers();
            for (int i = 0; i < seed; i++)
            {
                tnums.Next();
            }
            Console.WriteLine(tnums.list[^1]);

            return Answer;
        }

        internal static int Answer = 0;
        internal static int Seed = 4;
    }

    class TriangleNumbers
    {
        public TriangleNumbers() 
        {
            list = new List<int>() { 1 };
        }

        public List<int> list;
        public int Next()
        {
            int total = 0;
            for (int i = 0; i < list.Count; i++)
            {
                total += list[0];
            }
            list.Add(total);
            return total;
        }
    }
}
