using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviAA2.Model
{
    public class Visite
    {
        #region properties
        private int id;
        private DateTime date;
        private int estVisiteProgramme;
        private string heureArriveeCabinet;
        private string heureDebutEntretien;
        private string heureDepartCabinet;
        private int idMedecin;
        private string idActeur;
        #endregion
        #region get/set
        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public int EstVisiteProgramme { get => estVisiteProgramme; set => estVisiteProgramme = value; }
        public string HeureArriveeCabinet { get => heureArriveeCabinet; set => heureArriveeCabinet = value; }
        public string HeureDebutEntretien { get => heureDebutEntretien; set => heureDebutEntretien = value; }
        public string HeureDepartCabinet { get => heureDepartCabinet; set => heureDepartCabinet = value; }
        public int IdMedecin { get => idMedecin; set => idMedecin = value; }
        public string IdActeur { get => idActeur; set => idActeur = value; }
        #endregion
    }
}
