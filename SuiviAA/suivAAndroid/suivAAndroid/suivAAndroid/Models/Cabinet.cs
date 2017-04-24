using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivAAndroid.Models
{
    public class Cabinet
    {
        #region propriétés
        [PrimaryKey]
        public int idCabinet { get; set; }
        public string longitudeGPS { get; set; }
        public string latitudeGPS { get; set; }
        public string cp { get; set; }
        public string ville { get; set; }
        public string rue { get; set; }
        #endregion

        #region constructors
        public Cabinet()
        {

        }
        #endregion
    }
}
