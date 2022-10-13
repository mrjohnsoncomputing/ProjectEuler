using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;

namespace ProjectEuler
{
    class Problem013
    {
        public static string Solve()
        {
            List<string> data = Helper.FileIO.ReadStrings("Problem13.txt");
            long product = 1;
            int number_length = data[0].Length-1;
            int set_length = data.Count;
            int zero_count = number_length * set_length;

            for (int i = 0; i < data.Count; i++)
            {
                List<int> number_list = NumberList.Make(data[i]);
                int digit = number_list[0];
                product *= digit;
            }

            Answer = product.ToString();
            return Answer;
        }

        //internal static int Answer = 0;
        internal static string Answer = "";
        internal static int Seed = 0;
        
    }

    class NumberList
    {
        public NumberList()
        {
            list = new List<string>();
        }

        internal List<string> list;

        public void AddToNumber(List<int> number)
        {
            int n = number.Count;
            for (int i = 0; i < n; i++)
            {
                // Start at the nth position in the existing number
                //list[^n];
                continue;
            }
        }

        public static List<int> Make(string number)
        {
            char[] _numberlist = number.ToCharArray();
            List<int> numberList = new List<int>();
            for (int i = 0; i < _numberlist.Count(); i++)
            {
                numberList.Add(_numberlist[i]);
            }
            return numberList;
        }

    }
}
