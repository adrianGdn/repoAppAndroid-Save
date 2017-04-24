using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivAAndroid.Models
{
    class Medecin
    {
        #region propriétés
        [PrimaryKey]
        public string nom { get; set; }
        public string prenom { get; set; }
        //ForeignKey
        public int idCabinet { get; set; }
        //foreignkey
        public int idVisiteur { get; set; }
        #endregion
    }
}
