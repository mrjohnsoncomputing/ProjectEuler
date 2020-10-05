using System;
using Microsoft.VisualBasic.CompilerServices;

namespace ProjectEuler
{
	internal class Problem1
	{
		internal static void Solve()
		{
			int result = 0;
			for (int i = 0; i < 1000; i++) {
				if (i % 3 == 0 || i % 5 == 0) {
					result += i;
				}
			}
			Formatting.PrintResult(result, 1);
		}
	}
}
