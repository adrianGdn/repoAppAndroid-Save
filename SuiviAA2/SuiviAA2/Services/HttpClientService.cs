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
        /// <summary>
        /// instancie un client Http
        /// 
        /// </summary>
        public async void CreateHttpClient()
        {
             HttpClient client = new HttpClient();
        }

        /// <summary>
        /// renvoit une string json de l'acteur avec les paramètre login et mdp
        /// </summary>
        /// <param name="login"></param>
        /// <param name="mdp"></param>
        /// <returns></returns>
        public async Task<string> loadActeur(string login, string mdp)
        {
            string urlActeur = "http://10.0.0.5/ppe3JoJuAd/gsbAppliFraisV2/webservices/w_visiteur.php" + "?" + "login=" + login + "&" + "pass=" + mdp;
            var response = await clientHttp.GetAsync(urlActeur);
            var json = response.Content.ReadAsStringAsync().Result;
            return json;
        }

        /// <summary>
        /// renvoit une string json des cabinets avec les paramètre login et mdp
        /// </summary>
        /// <param name="login"></param>
        /// <param name="mdp"></param>
        /// <returns></returns>
        public async Task<string> loadCabinets(string user)
        {
            string urlCabinet = "http://10.0.0.5/ppe3JoJuAd/gsbAppliFraisV2/webservices/w_cabinet.php" + "?" + "user=" + user;
            var response = await clientHttp.GetAsync(urlCabinet);
            var json = response.Content.ReadAsStringAsync().Result;
            return json;
        }

        /// <summary>
        /// renvoit une string json des Visites avec les paramètre login et mdp
        /// </summary>
        /// <param name="login"></param>
        /// <param name="mdp"></param>
        /// <returns></returns>
        public async Task<string> loadVisites(string user)
        {
            string urlVisite = "http://10.0.0.5/ppe3JoJuAd/gsbAppliFraisV2/webservices/w_visite.php" + "?" + "user=" + user;
            var response = await clientHttp.GetAsync(urlVisite);
            var json = response.Content.ReadAsStringAsync().Result;
            return json;
        }

        /// <summary>
        /// renvoit une string json du Medecin avec les paramètre login et mdp
        /// </summary>
        /// <param name="login"></param>
        /// <param name="mdp"></param>
        /// <returns></returns>
        public async Task<string> loadMedecin(string user)
        {
            string urlMedecin = "http://10.0.0.5/ppe3JoJuAd/gsbAppliFraisV2/webservices/w_medecin.php" + "?" + "user=" + user;
            var response = await clientHttp.GetAsync(urlMedecin);
            var json = response.Content.ReadAsStringAsync().Result;
            return json;
        }

    }
}
