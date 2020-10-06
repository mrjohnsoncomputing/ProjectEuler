using Helper;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    internal class Problem3
	{
		internal static void Solve()
		{
			Timer timer = new Timer();
			timer.Begin();
			long input = 600851475143;//13195;//600851475143;
			Primes primes = new Primes();
			List<long> factors = primes.GetPrimeFactors(input);
			Formatting.PrintResult(factors.Last().ToString(), 3, timer.Stop());
			
		}
	}
}
