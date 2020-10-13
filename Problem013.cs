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
                char[] number = data[i].ToCharArray();
                int digit = (int)Char.GetNumericValue(number[0]);
                product *= digit;
            }

            Answer = product.ToString();
            return Answer;
        }

        //internal static int Answer = 0;
        internal static string Answer = "";
        internal static int Seed = 0;
        
    }

    class StringNumber
    {
        public StringNumber()
        {
            list = new List<string>();
        }

        internal List<string> list;


    }
}
