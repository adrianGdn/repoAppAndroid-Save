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
        public string adresseCabinets = "http://ppe3JoJuAd/gsbAppliFraisV2/webservices/w_cabinet.php";
        public static string userId;
        #endregion


        #region methods
        public CabinetJson listeCabinets = new CabinetJson();
        public async Task<CabinetJson> loadCabinets()
        {
            HttpClient clientCabinets = new HttpClient();
            var response = await clientCabinets.GetAsync(adresseCabinets);
            var json = await response.Content.ReadAsStringAsync();
            listeCabinets = JsonConvert.DeserializeObject<CabinetJson>(json);

            return listeCabinets;
        }

        public void insertIntoSqlite()
        {

        }
        #endregion
    }
}
