using SQLite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviAA.Model
{
    public class Visite
    {
        #region properties
        private int id;
        private DateTime dateVisite;
        private int estVisiteProgramme;
        private string heureArriveeCabinet;
        private string heureDebutEntretien;
        private string heureDepartCabinet;
        private int idMedecin;
        private string idActeur;
        #endregion

        #region get/set
        [PrimaryKey, AutoIncrement, Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("dateVisite")]
        public DateTime DateVisite { get => dateVisite; set => dateVisite = value; }
        [Column("estVisiteProgramme")]
        public int EstVisiteProgramme { get => estVisiteProgramme; set => estVisiteProgramme = value; }
        [Column("heureArriveeCabinet")]
        public string HeureArriveeCabinet { get => heureArriveeCabinet; set => heureArriveeCabinet = value; }
        [Column("heureDebutEntretien")]
        public string HeureDebutEntretien { get => heureDebutEntretien; set => heureDebutEntretien = value; }
        [Column("heureDepartCabinet")]
        public string HeureDepartCabinet { get => heureDepartCabinet; set => heureDepartCabinet = value; }
        [Column("idMedecin")]
        public int IdMedecin { get => idMedecin; set => idMedecin = value; }
        [Column("idActeur")]
        public string IdActeur { get => idActeur; set => idActeur = value; }

        public object Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
        #endregion
    }


}
