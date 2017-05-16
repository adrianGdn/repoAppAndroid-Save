using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SuiviAA.Services
{
    public class HttpClientService : HttpClient
    {
        
        #region properties
        HttpClient clientHttp = new HttpClient();
        public string userId = Passerelle.userId;
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
            string urlActeur = "http://172.16.9.22/ppe3JoJuAd/gsbAppliFraisV2/webservices/w_visiteur.php" + "?" + "login=" + login + "&" + "pass=" + mdp;
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
        public async Task<string> loadCabinets(string userId)
        {
            string urlCabinet = "http://172.16.9.22/ppe3JoJuAd/gsbAppliFraisV2/webservices/w_cabinet.php" + "?" + "user=" + userId;
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
        public async Task<string> loadVisites(string userId)
        {
            string urlVisite = "http://172.16.9.22/ppe3JoJuAd/gsbAppliFraisV2/webservices/w_visite.php" + "?" + "user=" + userId;
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
        public async Task<string> loadMedecin(string userId)
        {
            string urlMedecin = "http://172.16.9.22/ppe3JoJuAd/gsbAppliFraisV2/webservices/w_medecin.php" + "?" + "user=" + userId;
            var response = await clientHttp.GetAsync(urlMedecin);
            var json = response.Content.ReadAsStringAsync().Result;
            return json;
        }

    }
}
