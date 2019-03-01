using System;
using System.Collections.Generic;
using System.Text;

namespace Exercices_Progressifs.Business.ChientEtChat
{
    class Chien : Animal
    {
        private int poids;

        public Chien(int âge, int poids) : base(âge)
        {
            this.poids = poids;
        }

        public override void EmetreUnSon()
        {
            Console.WriteLine("wouaf !");
        }

        public override int GetÂgeHumain()
        {
            return Chien.CalculerÂgeHumain(this.âge,this.poids);
        }

        public static int CalculerÂgeHumain(int âge, int poinds)
        {
            int âgeHumain = 0;

            if(poinds < 15)
            {
                if (âge == 1)
                {
                    âgeHumain = 20;
                }
                else if (âge >= 2)
                {
                    âgeHumain = 28 + (âge - 2) * 4;
                }
                else
                {
                    âgeHumain = 0;
                }
            }
            else if(poinds < 40)
            {
                if (âge == 1)
                {
                    âgeHumain = 18;
                }
                else if (âge >= 2)
                {
                    âgeHumain = 27 + (âge - 2) * 6;
                }
                else
                {
                    âgeHumain = 0;
                }
            }
            else
            {
                if (âge == 1)
                {
                    âgeHumain = 16;
                }
                else if (âge >= 2)
                {
                    âgeHumain = 22 + (âge - 2) * 9;
                }
                else
                {
                    âgeHumain = 0;
                }
            }
            return âgeHumain;
        }
    }
}
