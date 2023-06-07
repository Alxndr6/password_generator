using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generateur_mot_de_passe
{
    public static class Outils
    {
        static int DemanderNombre(string question)
        {
            int longueurInt = 0;

            while (true)
            {
                Console.Write(question);
                string reponse = Console.ReadLine();

                try
                {
                    longueurInt = int.Parse(reponse);
                    return longueurInt;
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("ERREUR : Vous devez entrer un nombre.");
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }

        public static int DemanderNombreEntre(string question, int min, int max, string messageErreurPersonnalise = null)
        {
            int nombre = DemanderNombre(question);

            if ((nombre >= min) && (nombre <= max))
            {
                return nombre;
            }
            if(messageErreurPersonnalise == null)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($"ERREUR : Le nombre doit être compris entre {min} et {max}.");

            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(messageErreurPersonnalise);

            }
            Console.ResetColor();
            Console.WriteLine();
            return DemanderNombreEntre(question, min, max, messageErreurPersonnalise);
        }

        public static int DemanderNombrePositifNonNul(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue, "ERREUR : Le nombre doit être positif et non nul.");
        }
    }
}
