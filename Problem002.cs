using System.Linq;
using Helper;

namespace ProjectEuler
{
	internal class Problem002
	{
		internal static int Solve()
		{
			Timer timer = new Timer();
			timer.Begin();
			var fibbonacci = new Fibbonacci(1, 2);
			while (fibbonacci.Num2 < 4000000)
			{
				fibbonacci.Next();
			}
			var evens = fibbonacci.Sequence.Where(x => x % 2 == 0);
			return evens.Sum();

		}
	}
}
