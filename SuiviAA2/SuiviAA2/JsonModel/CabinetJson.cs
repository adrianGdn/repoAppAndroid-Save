using Newtonsoft.Json;
using SuiviAA2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SuiviAA2.JsonModel
{
    public class CabinetJson
    {
        #region properties
        public List<Cabinet> cabinets { get; set; }
        #endregion
    }
}
