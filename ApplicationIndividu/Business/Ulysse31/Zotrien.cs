using System;
using System.Collections.Generic;
using System.Text;

namespace Exercices_Progressifs.Business.Ulysse31
{
    class Zotrien : MembreEquipage
    {
        protected Zotrien(string nom, int âge, bool pilote) : base(nom, âge, pilote)
        {
            this.SetSagesse((int)Math.Sqrt((double)this.GetAge()));
        }

        public void LirePensées()
        {
            Console.WriteLine("{0} lit dans les pensées...");
        }
    }
}
