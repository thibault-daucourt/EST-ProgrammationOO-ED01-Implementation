using System;
using System.Collections.Generic;
using System.Text;

namespace Exercices_Progressifs.Business.ChientEtChat
{
    abstract class Animal
    {
        protected int âge;

        public Animal(int âge)
        {
            this.âge = âge;
        }
        public override string ToString()
        {
            return string.Format("J'ai {0} ans ({1} ans humain).", this.âge, this.GetÂgeHumain());
        }

        public abstract int GetÂgeHumain();

        public abstract void EmetreUnSon();

    }
}
