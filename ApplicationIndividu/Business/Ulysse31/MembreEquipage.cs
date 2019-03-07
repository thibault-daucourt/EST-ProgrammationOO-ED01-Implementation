using System;
using System.Collections.Generic;
using System.Text;

namespace Exercices_Progressifs.Business.Ulysse31
{
    class MembreEquipage
    {
        private String nom;

        private int âge;

        private bool pilote;

        private int sagesse;


        public const int AGE_MINIMUM = 1;

        protected MembreEquipage(string nom, int âge, bool pilote)
        {
            this.nom = nom;

            if (AGE_MINIMUM >= âge)
                this.âge = âge;
            else
                this.âge = 1;

            this.pilote = pilote;
        }

        public string GetNom()
        {
            return this.nom;
        }

        public bool SaitPiloter()
        {
            return pilote;
        }

        public int GetSagesse()
        {
            return this.sagesse;
        }

        // asssesseur interne
        protected void SetSagesse(int sagesse)
        {
            this.sagesse = sagesse;
        }

        protected int GetAge()
        {
            return this.âge;
        }
    }
}