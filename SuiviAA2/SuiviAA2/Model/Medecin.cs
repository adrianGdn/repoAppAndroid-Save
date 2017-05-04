using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviAA2.Model
{
    public class Medecin
    {
        #region properties
        private int id;
        private string nom;
        private string prenom;
        private int idCabinet;
        private string idActeur;
        #endregion
        #region get/set
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int IdCabinet { get => idCabinet; set => idCabinet = value; }
        public string IdActeur { get => idActeur; set => idActeur = value; }
        #endregion
    }
}
