using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
	internal static class Formatting
	{
		public static void PrintResult(object result, int problem_number)
		{
			Console.WriteLine("The answer to problem " + problem_number + " is " + result);
		}

		public static void PrintList(List<long> list)
		{
			for (int i = 0; i < list.Count; i++)
			{
				Console.WriteLine(list[i]);
			}
		}
	}
}
