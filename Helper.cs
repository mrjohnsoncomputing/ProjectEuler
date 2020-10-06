using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Helper
{
	public class Fibbonacci
	{
		//private int _num1;
		//private int _num2;

		public Fibbonacci(int num1, int num2)
		{
			Num1 = num1;
			Num2 = num2;
			Sequence = new List<int>(){ num1, num2 };
		}

		public int Num1;
		public int Num2;
		public List<int> Sequence;

		public int Next()
		{
			int temp = Num1;
			Num1 = Num2;
			Num2 += temp;
			Sequence.Add(Num2);
			return Num2;
		}

		public void Generate(int iterations) 
		{
			for (int i = 0; i < iterations; i++)
			{
				Next();
			}
		}
	}
	// Var fibbonacci = new Helper.Fibonnacci()
	// protected - inherited only, public - everything, internal - project, private - class

	public class Primes
	{
		public Primes()
		{
			list = new List<long>();
			N = 1;
		}

		public List<long> list;
		private long N { get; set; }

		public bool IsPrime(long number)
		{
			long halfway = number / 2;
			for (int i = 3; i < halfway; i+=2)
			{
				if (number % i == 0)
				{
					return false;
				}
			}
			return true;
		}

		public void Generate(long amount)
		{
			for (long i = N; i < N + amount; i+=2)
			{
				if (IsPrime(i))
				{
					list.Add(i);
				}
			}
			N += amount;
		}

		public List<long> GetPrimeFactors(long input)
		{
			long defecit = input - N;
			if (defecit > 0)
			{
				Generate(defecit);
			}

			List<long> factors = new List<long>();
			for (int i = 0; i < list.Count; i++)
			{
				if (input % list[i] == 0)
				{
					factors.Add(list[i]);
				}
			}
			return factors;
		}


	}
}
