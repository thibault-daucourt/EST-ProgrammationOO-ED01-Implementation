
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ApplicationIndividu.Business
{
    abstract class Monstre
    {
        private string nom;

        private int ptsDeVie;

        public Monstre(string nom, int ptsDeVie)
        {
            this.nom = nom;

            this.ptsDeVie = ptsDeVie;
        }

        public virtual void Attaquer()
        {
            Console.WriteLine("!*@? Je ne sais pas attaquer!.");
        }

        public override string ToString()
        {
            return "Je suis "+ this.nom +" et j’ai "+ this.ptsDeVie + " de vie.";
        }
    }
}