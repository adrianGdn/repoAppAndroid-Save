using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SuiviAA2.Model.SQLiteRepo
{
    public class CabinetRepository
    {
        #region properties
        private static string user;
        private static string pass;
        #endregion
        #region get/set
        public static string User { get => user; set => user = value; }
        public static string Pass { get => pass; set => pass = value; }
        #endregion

        #region methods
        public async Task<List<Cabinet>> GetCabinetAsync(string user)
        {            
            string urlCabinets = "http://10.0.0.5/ppe3JoJuAd/gsbAppliFraisV2/webservices/w_cabinet.php" + "?" + "user=" + user;

            IEnumerable<Cabinet>listeCabinet = Enumerable.Empty<Cabinet>();

            HttpClient clientCabinet = new HttpClient();
            clientCabinet.DefaultRequestHeaders.Accept.Clear();
            clientCabinet.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await clientCabinet.GetAsync(urlCabinets);

            var cabinetJson = response.Content.ReadAsStringAsync().Result;

            listeCabinet = await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<Cabinet>>(cabinetJson)).ConfigureAwait(false);


            return listeCabinet.ToList();
        }
        #endregion
    }
}
