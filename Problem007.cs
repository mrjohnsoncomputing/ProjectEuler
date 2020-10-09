using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem007
    {
        public static long Solve()
        {
            int seed = 10001;
            Primes primes = new Primes();
            primes.GenerateNPrimes(seed);
            return primes.list[seed - 1];
        }
    }
}
