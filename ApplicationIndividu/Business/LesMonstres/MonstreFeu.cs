using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationIndividu.Business
{
    class MonstreFeu : Monstre
    {
        public MonstreFeu(string nom, int ptsDeVie) : base(nom, ptsDeVie)
        {
        }


        public override void Attaquer()
        {
            Console.WriteLine("Je lance une boule de feu!.");
        }

        public override string ToString()
        {
            return base.ToString() + " Je suis un monstre de Feu.";
        }
    }
}
