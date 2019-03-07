using System;
using System.Collections.Generic;
using System.Text;

namespace Exercices_Progressifs.Business.Ulysse31
{
    class Robot : MembreEquipage
    {
        public enum ModelProcesseur { Copper34, Copper77, ExtendedCopper87};

        ModelProcesseur processeur;
        double vitesseProcesseur;


        public Robot(string nom, int âge, bool pilote, ModelProcesseur processeur, double vitesseProcesseur) : base(nom, âge, pilote)
        {
            this.processeur = processeur;

            this.vitesseProcesseur = vitesseProcesseur;

            this.SetSagesse((int) Math.Pow(this.vitesseProcesseur,Math.PI));
        }

        public void Calculer()
        {
            Console.WriteLine("{0} sais calculer bip bip bloup !", this.GetNom());
        }
    }
}
