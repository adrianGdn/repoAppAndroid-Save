using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivAAndroid.Models
{
    public class Visiteur
    {
        #region propriétés
        // Génère la BDD SQLite
        [PrimaryKey] //Définti l'id visiteur en PrimaryKey dans la base SQLite.
        public int idVisiteur { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Login { get; set; }
        public string Mdp { get; set; }
        public string Adresse { get; set; }
        public string CP { get; set; }
        public string Ville { get; set; }
        public string DateEmbauche { get; set; } // la Date est stockée en string dans la base de donnée distante.
        #endregion

        #region constructors
        public Visiteur()
        {

        }
        public Visiteur(string nom, string prenom, string login, string mdp, string adresse, string cp, string ville, string DateEmbauche)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Login = login;
            this.Mdp = mdp;
            this.Adresse = adresse;
            this.CP = cp;
            this.Ville = ville;
            this.DateEmbauche = DateEmbauche;
        }

        #endregion
    }
}
