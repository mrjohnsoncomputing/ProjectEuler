using Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
	internal class Problem3
	{
		internal static void Solve()
		{
			long input = 1000; //600851475143;
			Primes primes = new Primes();
			List<long> factors = primes.GetPrimeFactors(input);
			Formatting.PrintList(factors);
			
		}
	}
}
