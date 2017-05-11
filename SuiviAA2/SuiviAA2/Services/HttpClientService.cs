using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using SuiviAA2.JsonModel;
using Newtonsoft.Json;
using SuiviAA2.Model;

namespace SuiviAA2.Services
{
    public class HttpClientService:HttpClient
    {
        #region properties
        HttpClient clientHttp = new HttpClient();
        #endregion
        public async void CreateHttpClient()
        {
            HttpClient client = new HttpClient();
        }

        public async Task<string> loadActeur(string login, string mdp)
        {
            string urlActeur = "http://10.0.0.5/ppe3JoJuAd/gsbAppliFraisV2/webservices/w_visiteur.php" + "?" + "login=" + login + "&" + "pass=" + mdp;
            var response = await clientHttp.GetAsync(urlActeur);
            var json = response.Content.ReadAsStringAsync().Result;
            return json;
        }
    }
}
