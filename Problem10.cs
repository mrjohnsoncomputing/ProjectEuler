using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem10
    {
        private static readonly int seed = 2000000;
        internal static long answer = 0;
        public static long Solve()
        {
            Primes primes = new Primes();
            primes.CheckNForPrimes(seed);
            //Formatting.PrintList(primes.list);
            answer = primes.list.Sum();
            return answer;
        }
    }
}
