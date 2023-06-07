using System;

namespace generateur_mot_de_passe
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NOMBRE_MDP = 10; // Définit le nombre de mots de passe générés avec les paramètres choisis par l'utilisateur.

            string minuscules = "abcdefghijklmnopqrstuvwxyz";
            string majuscules = minuscules.ToUpper();
            string chiffres = "0123456789";
            string caracteresSpeciaux = "!?&@/-_~";
            string alphabet; // Contiendra les différentes parties concaténées selon le choix de l'utilisateur via "int choixAlphabet".
            string motDePasse = "";
            Random rand = new Random();

            int longueurMotDePasse = Outils.DemanderNombrePositifNonNul("Longueur de mot de passe : ");
            Console.WriteLine();
            int choixAlphabet = Outils.DemanderNombreEntre("1 - Uniquement des caractères en minuscule\n" + "2 - Des caractères minuscules et majuscules\n" +
                "3 - Des caractères et des chiffres\n" + "4 - Caractères, chiffres et caractères spéciaux\n" + "Entrez votre choix : ", 1, 4);

            if (choixAlphabet == 1 )
            {
                alphabet = minuscules;
            }
            else if (choixAlphabet == 2 )
            {
                alphabet = minuscules + majuscules;
            }
            else if (choixAlphabet == 3 )
            {
                alphabet = minuscules + majuscules + chiffres;
            }
            else
            {
                alphabet = minuscules + majuscules + chiffres + caracteresSpeciaux;
            }

           int longueurAlphabet = alphabet.Length;

            for(int j = 0; j < NOMBRE_MDP; j++) // Boucle selon le nombre de MDP choisi dans NOMBRE_MDP.
            {
                motDePasse = "";
                for (int i = 0; i < longueurMotDePasse; i++)
                {
                    int index = rand.Next(0, longueurAlphabet);
                    motDePasse += alphabet[index];
                }
                Console.WriteLine($"Votre mot de passe : {motDePasse}");
            }

        }
    }
}