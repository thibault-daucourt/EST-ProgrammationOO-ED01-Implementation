using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationIndividu.Business
{
    class Hotel
    {
        public enum Categorie
        {
            SWISS_LODGE,
            SWISS_LODGE_GARNI,
            ETOILE_1,
            ETOILE_2,
            ETOILE_3,
            ETOILE_4,
            ETOILE_5,
            SUPERIOR
        }

        private Personne directeur;

        private String nom;

        public const int CAPACITY_MAX = 20;

        private List<Personne> clients = new List<Personne>();

        private Categorie categorie;

        /// <summary>
        /// Construit un hotel
        /// </summary>
        /// <param name="nom">nom de l'hotel</param>
        /// <param name="directeur">directeur de l'hotel</param>
        /// <param name="categorie">categorie de l'hotel</param>
        public Hotel(string nom, Personne directeur, Categorie categorie)
        {
            this.nom = nom;
            this.directeur = directeur;
            this.categorie = categorie;
        }

        /// <summary>
        /// Ajoute un client à cet hôtel, pour autant
        /// que l'hôtel ne soit pas complet et qu'un
        /// même client n'en fasse pas déjà partie.
        /// </summary>
        /// <param name="client">client souhaitant rejoindre l'hotel</param>
        public void AjouterClient(Personne client)
        {
            Console.Write(client.GetNomPrenom());

            //hotel complet
            if(this.clients.Count == CAPACITY_MAX)
            {
                Console.WriteLine(" ne peut pas être accueilli, l’hôtel est complet");
            }
            //client déjà logé dans l'hotel
            else if (this.clients.Contains(client))
            {
                Console.WriteLine(" est déjà hébergé par l’hôtel");
            }else
            {
                clients.Add(client);
                Console.WriteLine(" arrive à l’hôte");
            }
        }

        public void RetirerClient(Personne client)
        {
            Console.Write(client.GetNomPrenom());

            if (clients.Remove(client))
            {
                Console.WriteLine(" quitte l'hôtel.");
            }
            else
            {
                Console.WriteLine(" n’était pas hébergé par l’hôtel");
            }
        }

        /// <summary>
        /// Indique le nombre de clients héberger par l'hôtel
        /// </summary>
        /// <returns> le nombre de clients héberger par l'hôtel</returns>
        public int GetNombreClient()
        {
            return this.clients.Count;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1},. Directeur : {2}, Clients : {3})",this.nom,this.GetNomCategorie(this.categorie), this.directeur.GetNomPrenom(), this.GetNombreClient());
        }

        /// <summary>
        /// Converti la catégorie en un labelle affichable
        /// </summary>
        /// <param name="categorie"> catégorie à afficher</param>
        /// <returns>labelle représentatn la categorie</returns>
        public  string GetNomCategorie(Categorie categorie)
        {
            string labelle = "";

            switch (categorie)
            {
                case Categorie.SWISS_LODGE : labelle = "Swiss Lodge";break;
                case Categorie.SWISS_LODGE_GARNI: labelle = "Swiss Lodge Garni"; break;
                case Categorie.ETOILE_1: labelle = "*"; break;
                case Categorie.ETOILE_2: labelle = "**"; break;
                case Categorie.ETOILE_3: labelle = "***"; break;
                case Categorie.ETOILE_4: labelle = "****"; break;
                case Categorie.ETOILE_5: labelle = "*****"; break;
                case Categorie.SUPERIOR: labelle = "Superior"; break;
                default: labelle = "Swiss Lodge"; break;
            }

            return labelle;
        }
    }

}
