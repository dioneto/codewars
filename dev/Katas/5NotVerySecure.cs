using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codewars.dev.Katas
{
    public static class NotVerySecure
    {
        public static bool Alphanumeric(string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return false;
            if (!str.All(char.IsLetterOrDigit)) return false;

            return true;
        }
    }
}
