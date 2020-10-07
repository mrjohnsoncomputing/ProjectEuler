using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;

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

	internal class Timer
	{
		public Timer()
		{
			stopwatch = new Stopwatch();
		}

		private Stopwatch stopwatch;

		public void Begin() 
		{
			stopwatch.Reset();
			stopwatch.Start();
		}

		public String Stop()
		{
			stopwatch.Stop();
			TimeSpan ts = stopwatch.Elapsed;
			// Format and display the TimeSpan value.
			return String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
			
		}
	}

	public class Primes
	{ 
		private long _n;

		public Primes()
		{
			list = new List<long>() {2};
			N = 3;
		}

		public List<long> list;
		
		private long N 
		{
			get { return _n; }
			set 
			{
				if (value % 2 == 0)
				{
					_n = value + 1;
				}
				else 
				{
					_n = value;
				}
			}
		}

		

		private void GenerateBatchOfPrimes(int batchSize, long startPosition)
		{
			//Timer timer = new Timer();
			//timer.Begin();

			for (long i = startPosition; i < startPosition + batchSize; i+=2)
			{
				AddToListIfPrime(i);
			}
			//Console.WriteLine("Start: " + startPosition + " || Generated " + batchSize + " prime numbers in " + timer.Stop());
		}

		public void GenerateNPrimes(int amountToGenerate)
		{
			while (list.Count < amountToGenerate)
			{
				CheckNForPrimes(1000000);
			}
		}

		public void CheckNForPrimes(double amountToGenerate)
		{
			int batchSize = 100000;
			if (amountToGenerate < batchSize)
			{
				batchSize = 1;
			}
			for (long i = N; i < amountToGenerate; i+= batchSize)
			{
				GenerateBatchOfPrimes(batchSize, i);
			}
			N += (long)amountToGenerate;
			//FileIO.WriteList("primes.txt", list);
		}

		public void AddToListIfPrime(long i)
		{
			if (IsPrime(i))
			{
				list.Add(i);
			}
		}

		public bool IsPrime(long number)
		{
			var sqrt = Math.Sqrt(number);
			for (int i = 2; i <= sqrt; i++)
			{
				if (number % i == 0)
				{
					return false;
				}
			}
			return true;
		}

		public List<long> GetPrimeFactors(long input)
		{

			CheckNForPrimes(Math.Sqrt(input));
			

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

	class FileIO 
	{
		public static void Write(string filename, string content)
		{
			string path = GetPath(filename);
			// Create a file to write to.
			using StreamWriter sw = File.CreateText(path);
			sw.WriteLine(content);
		}

		public static void WriteList(string filename, List<long> list) 
		{
			string content = "";
			for (int i = 0; i < list.Count(); i++)
			{
				content += list[i].ToString() + ",";
			}
			Write(filename, content);
		}

		public static List<long> ReadLongs(string filename)
		{
			string path = GetPath(filename);
			// Open the file to read from.
			using StreamReader sr = File.OpenText(path);
            string s = "";
			List<long> intlist = new List<long>();
			while ((s = sr.ReadLine()) != null)
            {

                string[] intItems = s.Split(',');
				for (int i = 0; i < intItems.Count(); i++)
				{
					try
					{
						var item = Int64.Parse(intItems[i]);
						intlist.Add(item);
					}
					catch
					{ 
						
					}
				}
				
            }
			return intlist;
        }

		private static string GetPath(string filename) 
		{
			return Path.Combine(new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName, @"Data\", filename);
		}
	}

}
