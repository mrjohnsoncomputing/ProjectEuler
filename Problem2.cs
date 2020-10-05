using System.Linq;
using Helper;

namespace ProjectEuler
{
	internal class Problem2
	{
		internal static void Solve()
		{
			var fibbonacci = new Fibbonacci(1, 2);
			while (fibbonacci.Num2 < 4000000)
			{
				fibbonacci.Next();
			}
			var evens = fibbonacci.Sequence.Where(x => x % 2 == 0);
			int answer = evens.Sum();
			Formatting.PrintResult(answer, 2);
		}
	}
}
