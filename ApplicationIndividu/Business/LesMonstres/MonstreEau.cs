using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationIndividu.Business
{
    class MonstreEau : Monstre
    {
        public MonstreEau(string nom, int ptsDeVie) : base(nom, ptsDeVie)
        {
        }


        public override void Attaquer()
        {
            Console.WriteLine("Je lance un tourbillon d’eau!.");
        }

        public override string ToString()
        {
            return base.ToString() + " Je suis un monstre d'Eau.";
        }
    }
}
