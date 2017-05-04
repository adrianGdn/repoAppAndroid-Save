using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SuiviAA2.Model
{
    public class Cabinet
    {
        #region properties
        private int id;
        private string longitudeGPS;
        private string latitutdeGPS;
        private string cp;
        private string ville;
        private string rue;
        #endregion
        #region get/set
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get => id; set => id = value; }
        public string LongitudeGPS { get => longitudeGPS; set => longitudeGPS = value; }
        public string LatitutdeGPS { get => latitutdeGPS; set => latitutdeGPS = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Ville { get => ville; set => ville = value; }
        public string Rue { get => rue; set => rue = value; }
        #endregion
    }
}
