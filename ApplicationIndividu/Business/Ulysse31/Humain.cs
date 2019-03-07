using System;
using System.Collections.Generic;
using System.Text;

namespace Exercices_Progressifs.Business.Ulysse31
{
    internal class Humain : MembreEquipage
    {
        const int AGE_MAJORITE = 18;
        const int AGE_RETRAITE = 70;

        protected Humain(string nom, int âge, bool pilote) : base(nom, âge, pilote)
        {
            if(this.GetAge() < AGE_MAJORITE || this.GetAge() >= AGE_RETRAITE)
            {
                this.SetSagesse(this.GetAge());
            }
            else
            {
                this.SetSagesse(this.GetAge() + 20);
            }
        }
    }
}
