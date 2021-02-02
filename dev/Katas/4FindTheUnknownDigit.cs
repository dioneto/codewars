using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace codewars.dev.Katas
{
    public static class FindTheUnknownDigit
    {
        public static int solveExpression(string value)
        {
            //"1+1=?"
            var x = value.Split('=');
            var dt = new DataTable();
            int a, b;
            for (int i = 9; i >= -9; i--)
            {
                a = (int)dt.Compute(x[0].Replace("?", i.ToString()), "");
                b = Convert.ToInt32(x[1].Replace("?", i.ToString()));
                if (a == b) return i;
            }

            return 0;
        }
    }
}
