
using ApplicationIndividu.Business;
using Exercices_Progressifs.Business.CercleEtCylindre;
using Exercices_Progressifs.Business.ChientEtChat;
using Exercices_Progressifs.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationIndividu
{
    class Application
    {
        /// <summary>
        /// Détermine l'individu le plus vieux des deux et 
        /// affiche une chaine de caractère dans la console pour informer l'utilisateur
        /// Si les deux indivodu ont la même année de naissance en informe l'utilisateur via la console 
        /// </summary>
        /// <param name="firstIndividu"> Première individu comparé</param>
        /// <param name="secondIndividu"> Second individu comparé</param>
        public static void Younger(Individu firstIndividu, Individu secondIndividu)
        {
            String youngerName = "";

            if (firstIndividu.AnneeNaissance < secondIndividu.AnneeNaissance)
                youngerName = secondIndividu.Nom;
            else if (firstIndividu.AnneeNaissance > secondIndividu.AnneeNaissance)
                youngerName = firstIndividu.Nom;

            if (youngerName.Length != 0)
                Console.WriteLine("L'individu le plus jeune : " + youngerName);
            else
                Console.Write("Ils sont aussi vieux l'un que l'autre !");
        }

        /// <summary>
        /// Exercice 3.2 de la série d'exercices progressifs de Jerome Conus
        /// </summary>
        public static void IndividuBis()
        {
            Individu firstIndividu = new Individu("Bejo", "Bérénice", 1976);
            Individu secondIndividu = new Individu("Dujardin", "Jean", 1972);

            Console.WriteLine(firstIndividu.presenter());
            Console.WriteLine(secondIndividu.presenter());

            secondIndividu.Nom = "Dupotager";
            firstIndividu.Nom = "Hazanavicious";

            Console.WriteLine("Nous changeons de noms.");

            Console.WriteLine(firstIndividu.presenter());
            Console.WriteLine(secondIndividu.presenter());
        }
        /// <summary>
        /// Exercice 3.3 de la série d'exercices progressifs de Jerome Conus
        /// </summary>
        public static void IndividuBisRepetita()
        {
            Individu firstIndividu = new Individu("Bejo", "Bérénice", 1976);
            Individu secondIndividu = new Individu("Dujardin", "Jean", 1972);

            Console.WriteLine(firstIndividu.presenter());
            Console.WriteLine(secondIndividu.presenter());

            secondIndividu.Prenom = "";
            secondIndividu.Nom = "";
            firstIndividu.AnneeNaissance = 2300;

            Console.WriteLine("Nous changeons de noms.");

            Console.WriteLine(firstIndividu.presenter());
            Console.WriteLine(secondIndividu.presenter());

            Application.Younger(firstIndividu, secondIndividu);
        }

        /// <summary>
        /// Exercice 3.5 de la série d'exercices progressifs de Jerome Conus
        /// </summary>
        public static void IndividuBientotFini()
        {
            Individu firstIndividu = new Individu("Dujardin", "Jean", 1972);
            Individu secondIndividu = new Individu("Bejo", "Bérénice", 1976);
            Individu thirdIndividu = new Individu("William", "Arthur Michael", 2018);
            Individu fourthIndividu = new Individu("Komarova", "Alexa", 2051);

            Console.WriteLine(firstIndividu.presenter());
            Console.WriteLine(secondIndividu.presenter());
            Console.WriteLine(thirdIndividu.presenter());
            Console.WriteLine(fourthIndividu.presenter());
        }

        public static void LeCouple()
        {
            List<Couple> couples = new List<Couple>();
            couples.Add(new Couple("Pierre Curie", "Marie Curie", 1895));
            couples.Add(new Couple("Michel Berger", "France Gall", 1976));
            couples.Add(new Couple("Robert Bidochon", "Raymonde Bidochon", 1977));

            foreach(Couple couple in couples)
            {
                Console.WriteLine(couple.ToString() + "\n");
            }
        }

        public static void LesMonstres()
        {
            List<Monstre> listeMonstres = new List<Monstre>();
            listeMonstres.Add(new MonstreFeu("Feunard", 5));
            listeMonstres.Add(new MonstreEau("Psychoqwack", 5));
            listeMonstres.Add(new MonstrePierre("Racaillou", 5));

            foreach(Monstre monstre in listeMonstres){
                Console.WriteLine(monstre.ToString());
                monstre.Attaquer();

                if (monstre is MonstrePierre)
                    (monstre as MonstrePierre).Attaquer(5);

                Console.WriteLine();
            }

            
        }

        public static void Hotel()
        {
            Personne directeur = new Personne("Pierre", "Bodenmann", 30, 3, 1952);

            Hotel hotel = new Hotel("L'informaticien Frigant", directeur, Business.Hotel.Categorie.ETOILE_3);

            hotel.AjouterClient(new Personne("Niklaus", "Wirth", 15, 2, 1934));
            hotel.AjouterClient(new Personne("Ada", "Lovelace", 10, 12, 1815));
            hotel.AjouterClient(new Personne("Alan", "Turing", 23, 6, 1912));
            hotel.AjouterClient(new Personne("Bjarne", "Stroustrup", 30, 12, 1950));
            hotel.AjouterClient(new Personne("Steve", "Wozniak", 11, 8, 1950));
            hotel.AjouterClient(new Personne("Dennis", "Richie", 9, 9, 1941));
            hotel.AjouterClient(new Personne("Grace", "Hopper", 9, 12, 1906));
            hotel.AjouterClient(new Personne("Alan", "Turing", 23, 6, 1912));

            Console.WriteLine();
            Console.WriteLine(hotel);
            Console.WriteLine();
            

        }

        public static void ChienEtChat()
        {
            Chat minet = new Chat(5);
            Chien médor = new Chien(7, 15);

            médor.EmetreUnSon();
            minet.EmetreUnSon();

            Console.WriteLine(médor.ToString());
            Console.WriteLine(minet.ToString());
        }

        public static void CercleEtCylindre()
        {
            Cylindre cylindre = new Cylindre(2.00, 5.00);

            Console.WriteLine("Volume du cylindre(rayon = {0}, hauteur = {1}) est de {2})", cylindre.GetRayonBaseCirculaire(), cylindre.GetHauteur(), cylindre.GetVolume());
        }
    }
}
