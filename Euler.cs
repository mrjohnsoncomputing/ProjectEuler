using Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
	internal class Euler
	{
		internal static void Main(string[] args) {
			Timer timer = new Timer();
			timer.Begin();
            var answer = Problem9.Solve();
			Formatting.PrintResult(answer, 9, timer.Stop());
		}
	}
}
