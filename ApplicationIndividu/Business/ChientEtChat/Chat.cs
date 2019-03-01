using System;
using System.Collections.Generic;
using System.Text;

namespace Exercices_Progressifs.Business.ChientEtChat
{
    class Chat : Animal
    {
        public Chat(int âge) : base(âge)
        {

        }

        public override void EmetreUnSon()
        {
            Console.WriteLine("miaou !");
        }

        public override int GetÂgeHumain()
        {
            return Chat.CalculerÂgeHumain(this.âge);

        }

        public static int CalculerÂgeHumain(int âge)
        {
            int âgeHumain = 0;

            if (âge == 1)
            {
                âgeHumain = 19;
            }
            else if( âge >= 2)
            {
                âgeHumain = 24 + (âge - 2) * 4;
            }
            else
            {
                âgeHumain = 0;
            }

            return âgeHumain;
        }
    }
}
