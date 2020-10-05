using System.Collections.Generic;
using System.Linq;

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
}
