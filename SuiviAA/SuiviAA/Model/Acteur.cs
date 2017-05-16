using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviAA.Model
{
    public  class Acteur
    {
        [JsonProperty("id")]
        public  string id { get; set; }
        [JsonProperty("nom")]
        public string nom { get; set; }
        [JsonProperty("prenom")]
        public string prenom { get; set; }
        [JsonProperty("login")]
        public string login { get; set; }
        [JsonProperty("mdp")]
        public string mdp { get; set; }
        [JsonProperty("adresse")]
        public string adresse { get; set; }
        [JsonProperty("cp")]
        public string cp { get; set; }
        [JsonProperty("ville")]
        public string ville { get; set; }
        [JsonProperty("dateEmbauche")]
        public string dateEmbauche { get; set; }
        [JsonProperty("idTypeActeur")]
        public string idTypeActeur { get; set; }
        [JsonProperty("oldMdp")]
        public string oldMdp { get; set; }
        [JsonProperty("mail")]
        public string mail { get; set; }
        [JsonProperty("questionSecrete")]
        public string questionSecrete { get; set; }
        [JsonProperty("version")]
        public string version { get; set; }

        #region methods

        #endregion
    }
}
