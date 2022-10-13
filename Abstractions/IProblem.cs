using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Abstractions
{
    public interface IProblem
    {
        string Name { get; set; }
        string Answer { get; set; }
        void Solve();
        void Print(object answer);
    }
}
