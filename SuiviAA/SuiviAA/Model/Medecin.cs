using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviAA.Model
{
    [Table("medecin")]
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
        [PrimaryKey, AutoIncrement, Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("nom")]
        public string Nom { get => nom; set => nom = value; }
        [Column("prenom")]
        public string Prenom { get => prenom; set => prenom = value; }
        [Column("idCabinet")]
        public int IdCabinet { get => idCabinet; set => idCabinet = value; }
        [Column("idActeur")]
        public string IdActeur { get => idActeur; set => idActeur = value; }
        #endregion
    }
}
