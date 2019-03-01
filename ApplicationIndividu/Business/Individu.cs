using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationIndividu
{
    class Individu
    {
        private String nom;
        private String prenom;
        private int anneeNaissance;

        //contructeur
        public Individu(string nom, string prenom, int anneeNaissance = 2000)
        {
            Nom = nom;
            Prenom = prenom;
            AnneeNaissance = anneeNaissance;
        }


        // Getter Setter
        public string Nom
        {
            set
            {
                if (value.Length != 0)
                    nom = value;
                else
                    Console.WriteLine("Le nom doit contenir au moins un caractères.");
            }

            get
            {
                return nom;
            }
        }

        public string Prenom
        {
            set
            {
                if (value.Length != 0)
                    prenom = value;
                else
                    Console.WriteLine("Le prenom doit contenir au moins un caractères.");
            }

            get
            {
                return prenom;
            }
        }

        public int AnneeNaissance
        {
            set
            {
                if (value >= 1900 && value <= 2200)
                    anneeNaissance = value;
                else
                    Console.WriteLine(value + " n'est pas une année valide.");
            }

            get
            {
                return anneeNaissance;
            }
        }

        /// <summary>
        /// fonction renvoyant une chaine de caractère présentant l'individu
        /// </summary>
        /// <returns> chaîne de caractères présentant l'individu</returns>
        public string presenter()
        {
            DateTime maintenant = DateTime.Now;
            int cetteAnnee = maintenant.Year;

            if (cetteAnnee == this.AnneeNaissance)
                return "Je m’appelle " + prenom + " " + nom + ". Je suis né(e) cette année !";
            else if (cetteAnnee > this.AnneeNaissance)
                return "Je m’appelle " + prenom + " " + nom + " et je suis né(e) en " + anneeNaissance + ".";
            else
                return "Je m’appelle " + prenom + " " + nom + ". Je ne suis pas encore né(e).";


        }
    }
}
