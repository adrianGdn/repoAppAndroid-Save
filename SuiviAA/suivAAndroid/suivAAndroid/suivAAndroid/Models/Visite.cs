using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivAAndroid.Models
{
    class Visite
    {
        #region propriétés
        [PrimaryKey, AutoIncrement]
        public int idVisite { get; set; }
        public DateTime dateVisite { get; set; }
        public bool estVisiteProgramme { get; set; }
        public DateTime heureArriveeCabinet { get; set; }
        public DateTime heaureDebutEntretien { get; set; }
        public DateTime heureDepartCabinet { get; set; }
        //foreignkey
        public int idMedecin { get; set; }
        //foreignkey
        public int idVisiteur { get; set; }
        #endregion

        #region methodes
        public Visite()
        {

        }
        public Visite(DateTime dateVisite, bool estProgramme, DateTime heureArriveCabinet, DateTime heureDebutEntretien, DateTime heureDepartCabinet)
        {

        }
        #endregion
    }
}
