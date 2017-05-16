using Newtonsoft.Json;
using SuiviAA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviAA.JsonModel
{
    public class ActeurJson
    {
        [JsonProperty("Acteur")]
        public Acteur Acteur { get; set; }
    }
}
