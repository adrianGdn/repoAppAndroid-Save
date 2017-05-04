using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviAA2.Model
{
    public class Acteur
    {
        #region properties
        private string id;
        private string nom;
        private string prenom;
        private string login;
        private string mdp;
        private string adresse;
        private string cp;
        private string ville;
        private DateTime dateEmbauche;
        private int idTypeActeur;
        private string oldMdp;
        private string mail;
        private string questionSecrete;
        private int version;
        #endregion

        #region get/set
        public string Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Login { get => login; set => login = value; }
        public string Mdp { get => mdp; set => mdp = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Ville { get => ville; set => ville = value; }
        public DateTime DateEmbauche { get => dateEmbauche; set => dateEmbauche = value; }
        public int IdTypeActeur { get => idTypeActeur; set => idTypeActeur = value; }
        public string OldMdp { get => oldMdp; set => oldMdp = value; }
        public string Mail { get => mail; set => mail = value; }
        public string QuestionSecrete { get => questionSecrete; set => questionSecrete = value; }
        public int Version { get => version; set => version = value; }
        #endregion
    }
}
