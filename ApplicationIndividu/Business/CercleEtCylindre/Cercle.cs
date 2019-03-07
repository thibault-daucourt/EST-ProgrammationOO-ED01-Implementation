using System;
using System.Collections.Generic;
using System.Text;

namespace Exercices_Progressifs.Business.CercleEtCylindre
{
    class Cercle
    {
        private double rayon;

        public Cercle(double rayon)
        {
            this.rayon = rayon;
        }

        public void SetRayon(double rayon)
        {
            this.rayon = rayon;
        }

        public double GetRayon()
        {
            return this.rayon;
        }

        public double GetAire()
        {
            return Math.PI * this.rayon * this.rayon;
        }
    }
}
