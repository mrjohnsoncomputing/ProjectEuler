using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
	internal static class Formatting
	{
		public static void PrintResult(object result, int problem_number, string timeTaken)
		{
			Console.WriteLine("The answer to problem " + problem_number + " is " + result + " || Time taken: " + timeTaken);
		}

		public static void PrintList(List<long> list)
		{
			for (int i = 0; i < list.Count; i++)
			{
				Console.WriteLine(list[i]);
			}
		}
		public static void PrintList(List<int> list)
		{
			for (int i = 0; i < list.Count; i++)
			{
				Console.WriteLine(list[i]);
			}
		}
	}
}
