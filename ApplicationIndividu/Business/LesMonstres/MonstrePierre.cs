using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationIndividu.Business
{
    class MonstrePierre : Monstre
    {
        public MonstrePierre(string nom, int ptsDeVie) : base(nom, ptsDeVie)
        {
        }


        public override void Attaquer()
        {
            Console.WriteLine("Je lance une salve de cailloux !.");
        }

        public void Attaquer(int nombre)
        {
            Console.WriteLine("Je lance {0} pierres!", nombre);
        }

        public override string ToString()
        {
            return base.ToString() + " Je suis un monstre de Pierre.";
        }
    }
}
