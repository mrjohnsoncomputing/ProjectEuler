using System;
using Helper;
using Microsoft.VisualBasic.CompilerServices;
using ProjectEuler.Abstractions;

namespace ProjectEuler
{
	public class Problem001 : IProblem
	{
		public Problem001(string name)
		{
			Name = name;
		}
		public string Name { get; set; }
		public string Answer { get; set; }
		public void Solve()
		{
			int result = 0;
			for (int i = 0; i < 1000; i++) {
				if (i % 3 == 0 || i % 5 == 0) {
					result += i;
				}
			}	
			Print(result); 
		}

		public void Print(object answer)
		{
			answer = (int)answer;
			Console.WriteLine($"The answer to question {Name} is {answer}.");
		}
	}
}
