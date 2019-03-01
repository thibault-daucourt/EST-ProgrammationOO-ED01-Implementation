using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ApplicationIndividu.Business
{
    class Personne
    {
        /// <summary>
        /// nom de la personne sous forme de String
        /// </summary>
        public String nom { get; set; }

        /// <summary>
        /// prenom de la personne sous forme de String
        /// </summary>
        public String prenom { get; set; }

        /// <summary>
        /// date de naissance de la personne sous forme de DateTime
        /// </summary>
        public DateTime naissance { get; set; }

        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="naissance"></param>
        public Personne(String nom, String prenom, DateTime naissance)
        {
            this.nom = nom;

            this.prenom = prenom;

            this.naissance = naissance;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nom">nom de la personne</param>
        /// <param name="prenom">prenom de la personne</param>
        /// <param name="jourNaissance">jour de la naissance de la personne</param>
        /// <param name="moisNaissance">mois de la naissance de la personne</param>
        /// <param name="anneeNaissance">annee de la naissance de la personne</param>
        public Personne(String nom, String prenom,int jourNaissance, int moisNaissance, int anneeNaissance)
        {
            this.nom = nom;

            this.prenom = prenom;

            this.naissance = new DateTime(anneeNaissance, moisNaissance, jourNaissance);
        }

        /// <summary>
        /// retourne une chaine comprenant le nom prenom de la personne
        /// </summary>
        /// <returns></returns>
        public string GetNomPrenom()
        {
            return string.Format("{0} {1} ", this.nom, this.prenom);
        }

        /// <summary>
        /// Détermine l'age de cette personne
        /// </summary>
        /// <returns></returns>
        public int GetAge()
        {
            //Calcule de l'age absolu
            TimeSpan age = DateTime.Now.Subtract(naissance);
            //retourn l'age en année 
            return (int)(age.Days / 365);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0} {1} ({2} ans)", this.GetNomPrenom(), this.naissance.ToString("MM/dd/yyy"), this.GetAge());
        }

        public override bool Equals(object obj)
        {
            var personne = obj as Personne;
            return personne != null &&
                nom != obj;
        }
    }
}