﻿using Newtonsoft.Json;
using SuiviAA2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviAA2.JsonModel
{
    public class ActeurJson
    {
        [JsonProperty("Acteur")]
        public Acteur Acteur { get; set; }
    }
}
