using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProjectEuler
{
    class Problem012
    {
        public static int Solve()
        {

            TriangleNumbers tnums = new TriangleNumbers();
            tnums.Next();
            while (Helper.DoMath.GetFactors(tnums.list[^1]) <= Seed)
            //for (int i = 0; i < Seed; i++)
            {
                tnums.Next();
            }
            //Console.WriteLine(tnums.list[^1]);

            return tnums.list[^1];
        }

        internal static int Answer = 0;
        internal static int Seed = 500;
    }

    class TriangleNumbers
    {
        public TriangleNumbers()
        {
            list = new List<int>();
        }

        public List<int> list;
        public int Next()
        {
            int total = list.Count + 1;
            try
            {
                total += list[^1];
            }
            catch
            {
                total = 1;
            }

            list.Add(total);
            return total;
        }

        public void GenerateBatch(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Next();
            }
        }
    }
}
