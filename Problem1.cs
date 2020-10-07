using System;
using Helper;
using Microsoft.VisualBasic.CompilerServices;

namespace ProjectEuler
{
	internal class Problem1
	{
		internal static int Solve()
		{
			Timer timer = new Timer();
			timer.Begin();
			int result = 0;
			for (int i = 0; i < 1000; i++) {
				if (i % 3 == 0 || i % 5 == 0) {
					result += i;
				}
			}
			return result; 
		}
	}
}
