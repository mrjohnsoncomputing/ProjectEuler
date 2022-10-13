using Helper;
using ProjectEuler.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
	internal class Euler
	{
		internal static void Main(string[] args) {
			string problemNumber = "001";
			string[] arguments = { problemNumber };
			string className = "Problem" + problemNumber;
			//IProblem problem = (IProblem)Activator.CreateInstance("ProjectEuler", className, arguments).Unwrap();
			IProblem problem = new Problem014(problemNumber);
			Runner.Run(problem);
		}
	}
}
