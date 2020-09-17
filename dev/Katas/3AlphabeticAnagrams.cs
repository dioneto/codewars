using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codewars.dev.Katas
{
    public static class AlphabeticAnagrams
    {
        public static long ListPosition(string value)
        {
            char[] letras = value.ToCharArray();
            string valueOrdenado = new string ( letras.OrderBy(x => x).Select(x => x).ToArray() );

            List<string> ret = Anagrama(valueOrdenado);

            for (int i = 0; i < value.Length; i++)
            {
                var items = ret.ToArray();
                foreach (var item in items)
                {
                    ret.AddRange(Anagrama(item));
                }
                ret = ret.Distinct().ToList();
                ret.Sort();
                var teste = ret.FindIndex(value.StartsWith);
                if (teste > 0) return teste + 1;
            }

            ret.Sort();
            return ret.FindIndex(value.StartsWith) + 1;
        }

        private static List<string> Anagrama(string s)
        {
            char[] letras = s.ToCharArray();

            List<string> ret = new List<string>();

            for (int x = 0; x < s.Length; x++)
            {
                var itemA = s[x];

                for (int i = 0; i < s.Length; i++)
                {
                    var itemB = s[i];
                    char[] novoItem = s.ToCharArray();
                    novoItem[i] = itemA;
                    novoItem[x] = itemB;
                    ret.Add(new string(novoItem));
                }
            }

            return ret;
        }
    }
}
