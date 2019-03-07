using System;
using System.Collections.Generic;
using System.Text;

namespace Exercices_Progressifs.Business.CercleEtCylindre
{
    class Cylindre
    {
        private double hauteur;

        // le cercle est un élément du cylindre
        // le cylindre n'est aps une extention d'un cercle
        private Cercle baseCiculaire;

        public Cylindre(double rayon, double hauteur)
        {
            this.baseCiculaire = new Cercle(rayon);

            this.hauteur = hauteur;
        }

        public void SetHauteur(double hauteur)
        {
            this.hauteur = hauteur;
        }

        public double GetHauteur()
        {
            return this.hauteur;
        }

        public void SetRayonBaseCirculaire(double rayon)
        {
            this.baseCiculaire.SetRayon(rayon);
        }

        public double GetRayonBaseCirculaire()
        {
            return this.baseCiculaire.GetRayon();
        }

        public double GetVolume()
        {
            return this.baseCiculaire.GetAire() * this.hauteur;
        }
    }
}
