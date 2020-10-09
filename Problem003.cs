using Helper;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    internal class Problem003
	{
		internal static string Solve()
		{
			Timer timer = new Timer();
			timer.Begin();
			long input = 600851475143;//13195;//600851475143;
			Primes primes = new Primes();
			List<long> factors = primes.GetPrimeFactors(input);
			return factors.Last().ToString();
			
		}
	}
}
