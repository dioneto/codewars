using System;
using System.Collections.Generic;
using System.Text;

namespace codewars.dev.Katas
{
    public class ParseIntReloaded
    {
        public static int ParseInt(string s)
        {
            Dictionary<string, int> numeros = new Dictionary<string, int>();
            numeros.Add("zero", 0);
            numeros.Add("one", 1);
            numeros.Add("two", 2);
            numeros.Add("three", 3);
            numeros.Add("four", 4);
            numeros.Add("five", 5);
            numeros.Add("six", 6);
            numeros.Add("seven", 7);
            numeros.Add("eight", 8);
            numeros.Add("nine", 9);
            numeros.Add("ten", 10);
            numeros.Add("eleven", 11);
            numeros.Add("twelve", 12);
            numeros.Add("thirteen", 13);
            numeros.Add("fourteen", 14);
            numeros.Add("fifteen", 15);
            numeros.Add("sixteen", 16);
            numeros.Add("seventeen", 17);
            numeros.Add("eighteen", 18);
            numeros.Add("nineteen", 19);
            numeros.Add("twenty", 20);
            numeros.Add("thirty", 30);
            numeros.Add("forty", 40);
            numeros.Add("fifty", 50);
            numeros.Add("sixty", 60);
            numeros.Add("seventy", 70);
            numeros.Add("eighty", 80);
            numeros.Add("ninety", 90);

            Dictionary<string, int> multiplicadores = new Dictionary<string, int>();
            multiplicadores.Add("hundred", 100);
            multiplicadores.Add("thousand", 1000);
            multiplicadores.Add("million", 1000000);

            string[] texto = s.Replace('-', ' ').Split(' ');
            int[] numero = new int[2];
            int i = 0;
            numero[0] = 0;
            numero[1] = 0;

            foreach (var item in texto)
            {
                numero[i] += numeros.GetValueOrDefault(item);
                numero[i] = numero[i] * multiplicadores.GetValueOrDefault(item, 1);
                if (item == "thousand") i++;
            }

            return numero[0] + numero[1];
        }
    }
}
