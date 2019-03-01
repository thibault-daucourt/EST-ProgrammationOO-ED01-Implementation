using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ApplicationIndividu
{
    class Couple
    {
        public String marie;

        public String épouse;

        public int annéeMariage;

        public Couple (string marie, string épouse, int annéeMariage)
        {
            this.marie = marie;

            this.épouse = épouse;

            this.annéeMariage = annéeMariage;
        }

        public string GetMarie()
        {
            return this.marie;
        }

        public string GetEpouse()
        {
            return this.épouse;
        }

        public int GetAnnéeMariage()
        {
            return this.annéeMariage;
        }

        public override string ToString()
        {
            return this.GetMarie() + " et " + this.GetEpouse() + " se sont mariés en " + this.GetAnnéeMariage() + ".";
        }
    }
}