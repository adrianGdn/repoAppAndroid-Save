using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using SuiviAA2.Model;
using Newtonsoft.Json;

namespace SuiviAA2.Services
{
    public class ClientCabinets
    {
        #region properties
        //Définit le lien de récupération du json des cabinets
        private const string ApiBaseAdress = "http://ppe3JoJuAd/gsbAppliFraisV2/webservices/w_cabinet.php";
        #endregion
        #region constructor
        //constructeur vide du client de cabinets
        public ClientCabinets()
        {

        }
        #endregion
        #region methods
        /// <summary>
        /// Crée un client http et récupère les cabinets en json
        /// </summary>
        /// <returns></returns>
        private HttpClient CreateClient(string idActeur)
        {
            //instancie un objet HttpClient
            var httpClient = new HttpClient();
            {
                //formate l'adresse http servant à la réquête
               var BaseAddress = new Uri(ApiBaseAdress + "user=" + idActeur);
            }

            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return httpClient;
        }

        public async Task<List<Cabinet>> GetCabinets(string idActeur)
        {
            //création d'une liste de cabinet, on peut y appeler les méthodes de l'interface IEnumerable
            IEnumerable<Cabinet> listeCabinets = Enumerable.Empty<Cabinet>();
            //Crée un client http avec l'id de l'acteur en paramètre
            using (var httpClient = CreateClient(idActeur))
            {
                //récupère le résultat de la requête et le stock dans response
                var response = await httpClient.GetAsync("Cabinet").ConfigureAwait(false);
                //Si la réponse est OK
                if (response.IsSuccessStatusCode)
                {
                    //Récupérer le json et le lire en tant que string
                    var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    //Si la string n'est pas vide
                    if(!string.IsNullOrWhiteSpace(json))
                    {
                        //Désérialise l'objet json en objet cabinet
                        listeCabinets = await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<Cabinet>>(json)).ConfigureAwait(false);
                    }
                }
            }
            //retourne une liste de cabinets
            return listeCabinets.ToList();
        }
        #endregion
    }
}
