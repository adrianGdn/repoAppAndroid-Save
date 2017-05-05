using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SuiviAA2.Model
{
    [Table("cabinet")]
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
        [PrimaryKey, AutoIncrement, Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("longitudeGPS")]
        public string LongitudeGPS { get => longitudeGPS; set => longitudeGPS = value; }
        [Column("latitudeGPS")]
        public string LatitutdeGPS { get => latitutdeGPS; set => latitutdeGPS = value; }
        [Column("cp")]
        public string Cp { get => cp; set => cp = value; }
        [Column("ville")]
        public string Ville { get => ville; set => ville = value; }
        [Column("rue")]
        public string Rue { get => rue; set => rue = value; }
        #endregion
    }
}
