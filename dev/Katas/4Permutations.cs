using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codewars.Katas
{
    public static class Permutations
    {
        /*
         * In this kata you have to create all permutations of an input string and remove duplicates, if present. 
         * This means, you have to shuffle all letters from the input in all possible orders.
         * Examples:
         * Permutations.SinglePermutations("a"); // => new List {"a"}
         * Permutations.SinglePermutations("ab"); // => new List {"ab", "ba"}
         * Permutations.SinglePermutations("aabb"); // => new List {"aabb", "abab", "abba", "baab", "baba", "bbaa"}
         * The order of the permutations doesn't matter.
         * 
         */
        public static void Tests()
        {
            Console.WriteLine("a => ");
            var retA = SinglePermutations("a");
            foreach (var item in retA)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("ab => ");
            var retAb = SinglePermutations("ab");
            foreach (var item in retAb)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("aabb => ");
            var retaabb = SinglePermutations("aabb");
            foreach (var item in retaabb)
            {
                Console.WriteLine(item);
            }
        }

        public static List<string> SinglePermutations(string s)
        {
            List<string> ret = Permitations(s);

            for (int i = 0; i < s.Length; i++)
            {
                var items = ret.ToArray();
                foreach (var item in items)
                {
                    ret.AddRange(Permitations(item));
                }
                ret = ret.Distinct().ToList();
            }

            ret.Sort();
            return ret;
        }

        private static List<string> Permitations(string s)
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
