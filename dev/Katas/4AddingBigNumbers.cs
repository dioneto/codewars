using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codewars.dev.Katas
{
    public static class AddingBigNumbers
    {
        public static string Add(string a, string b)
        {
            int[] numA = new int[a.Length];
            int[] numB = new int[b.Length];

            int[] ret = new int[a.Length > b.Length ? a.Length + 1 : b.Length + 1];

            numA = a.Select(x => Convert.ToInt32(x)).ToArray();
            numB = b.Select(x => Convert.ToInt32(x)).ToArray();

            for (int i = 0; i < (a.Length > b.Length ? a.Length: b.Length); i++)
            {
                ret[ret.Length - i - 1] = a[a.Length - i - 1] + b[b.Length - i - 1];
            }

            return "0"; // Fix this!
        }
    }
}
