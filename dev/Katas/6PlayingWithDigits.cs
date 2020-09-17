using System;
using System.Collections.Generic;
using System.Text;

namespace codewars.dev.Katas
{
    public static class PlayingWithDigits
    {
        public static long digPow(int n, int p)
        {

            double numero = 0;
 
            char[] nums = n.ToString().ToCharArray();

            for (int i = 0; i < nums.Length; i++)
            {
                numero += Math.Pow(Convert.ToDouble(nums[i].ToString()), Convert.ToDouble(p + i));
            }
            var resultado = numero / n;

            return resultado == Convert.ToInt64(resultado) ? Convert.ToInt64(resultado) : -1;
        }
    }
}
