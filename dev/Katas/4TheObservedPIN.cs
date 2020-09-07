using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codewars.dev.Katas
{
    public static class TheObservedPIN
    {
        private static List<string> _possiveisDigitos { get; set; }
        private static List<string> PossiveisDigitos
        {
            get { return _possiveisDigitos; }
            set
            {
                if (_possiveisDigitos.Count == 0)
                {
                    _possiveisDigitos.AddRange(value);
                }
                else
                {
                    var itensAtuais = PossiveisDigitos;
                    _possiveisDigitos = new List<string>();

                    foreach (var item in itensAtuais)
                    {
                        foreach (var novoDigito in value)
                        {
                            _possiveisDigitos.Add(item + novoDigito);
                        }
                    }
                }
            }
        }
        public static List<string> GetPINs(string observed)
        {
            _possiveisDigitos = new List<string>();
            PossiveisDigitos = new List<string>();
            var dicionario = new Dictionary<string, string[]>{
                { "0", new[] { "0", "8" } },
                { "1", new[] { "1", "2", "4"} },
                { "2", new[] { "2", "1", "3", "5"} },
                { "3", new[] { "3", "2", "6"} },
                { "4", new[] { "4", "1", "5", "7"} },
                { "5", new[] { "5", "2", "4", "6", "8" } },
                { "6", new[] { "6", "3", "5", "9" } },
                { "7", new[] { "7", "4", "8"} },
                { "8", new[] { "8", "5", "7", "9", "0" } },
                { "9", new[] { "9", "6", "8"} } };

            foreach (var item in observed.ToArray())
            {
                string[] valores;
                dicionario.TryGetValue(item.ToString(), out valores);
                PossiveisDigitos = valores.ToList();
            }

            return PossiveisDigitos;
        }
    }
}
