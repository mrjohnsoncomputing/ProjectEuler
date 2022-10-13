using ProjectEuler.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem014 : IProblem
    {
        private readonly int MAX = 1000000;
        public Problem014(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public string Answer { get; set; }
        public int recordNumber { get; set; } = 0;
        public int recordChainLength { get; set; } = 0;
        public void Solve()
        {
            var skippableValues = new List<int>();
            for (int i = 1; i < MAX; i++)
            {
                
                var chain = CreateCollatzChain(i);
                    
                if (chain.Count > recordChainLength)
                {
                    recordChainLength = chain.Count;
                    recordNumber = i;
                }
               
            }
            Answer = recordNumber.ToString();
        
        }

        
        private List<int> CreateCollatzChain(int n)
        {
            var chain = new List<int>();
            while (n > 1)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                }
                else
                {
                    n = (3 * n) + 1;
                }
                chain.Add(n);
            }

            return chain;
        
        }

        public void Print(object answer)
        { 
            
        }
    }
}
