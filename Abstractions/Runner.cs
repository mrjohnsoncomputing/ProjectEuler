using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ProjectEuler.Abstractions
{
    public class Runner
    {
        public static void Run(IProblem problem)
        {
            Timer timer = new Timer();
            timer.Begin();
            problem.Solve();
            Formatting.PrintResult(problem.Answer, 14, timer.Stop());
        }
    }
}
