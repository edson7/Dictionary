using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Dictionary");
            Console.ReadKey();
        }
        public static Dictionary<char, int> ChaineCaractere(string chaine)
        {
            if (chaine == null)
            {
                return null;
            }
            Dictionary<char, int> dictionnaire = new Dictionary<char, int>();

            string chaineFinale = chaine.ToLower();
            const int COMPTEUR = 1;

            for (int i = 0; i < chaineFinale.Length; i++)
            {

                if (char.IsLetterOrDigit(chaineFinale[i]))
                {
                    if (!dictionnaire.ContainsKey(chaineFinale[i]))
                    {
                        dictionnaire.Add(chaineFinale[i], COMPTEUR);
                    }
                    else
                    {
                        dictionnaire[chaineFinale[i]] += 1;
                    }
                }
            }

            return dictionnaire;
        }
    }
}
