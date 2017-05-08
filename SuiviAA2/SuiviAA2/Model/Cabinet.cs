using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Collections;

namespace SuiviAA2.Model
{
    [Table("cabinet")]
    public class Cabinet
    {
        #region properties
        private int id;
        private string longitudeGPS;
        private string latitutdeGPS;
        private string cp;
        private string ville;
        private string rue;
        //Définit le lien de récupération du json des cabinets
        private const string ApiBaseAdress = "http://ppe3JoJuAd/gsbAppliFraisV2/webservices/w_cabinet.php";
        #endregion
        #region get/set
        [PrimaryKey, AutoIncrement, Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("longitudeGPS")]
        public string LongitudeGPS { get => longitudeGPS; set => longitudeGPS = value; }
        [Column("latitudeGPS")]
        public string LatitutdeGPS { get => latitutdeGPS; set => latitutdeGPS = value; }
        [Column("cp")]
        public string Cp { get => cp; set => cp = value; }
        [Column("ville")]
        public string Ville { get => ville; set => ville = value; }
        [Column("rue")]
        public string Rue { get => rue; set => rue = value; }
        #endregion
        #region methods
        //public async Task<List<Cabinet>> GetCabinets(string idActeur)
        //{
        //    //instancie un objet HttpClient
        //    var httpClient = new HttpClient();
        //    {
        //        //formate l'adresse http servant à la réquête
        //        var BaseAddress = new Uri(ApiBaseAdress + "user=" + idActeur);
        //    }

        //    httpClient.DefaultRequestHeaders.Accept.Clear();
        //    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));//instancie un objet HttpClient

        //    //création d'une liste de cabinet, on peut y appeler les méthodes de l'interface IEnumerable
        //    IEnumerable<Cabinet> listeCabinets = Enumerable.Empty<Cabinet>();
        //    //Crée un client http avec l'id de l'acteur en paramètre

        //    //récupère le résultat de la requête et le stock dans response
        //    var response = await httpClient.GetAsync("Cabinet").ConfigureAwait(false);
        //    //Si la réponse est OK
        //    if (response.IsSuccessStatusCode)
        //    {
        //        //Récupérer le json et le lire en tant que string
        //        var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        //        //Si la string n'est pas vide
        //        if (!string.IsNullOrWhiteSpace(json))
        //        {
        //            //Désérialise l'objet json en objet cabinet
        //            listeCabinets = await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<Cabinet>>(json)).ConfigureAwait(false);
        //        }
        //    }

        //    //retourne une liste de cabinets
        //    return listeCabinets.ToList();
        //}
        #endregion
    }

    public class CabinetsList
    {
        public List<Cabinet> cabinets { get; set; }


        public string adresseCabinets = "http://ppe3JoJuAd/gsbAppliFraisV2/webservices/w_cabinet.php";
        public static string userId;
        #region methods
        public CabinetsList listeCabinets = new CabinetsList();
        public async Task<CabinetsList> loadCabinets()
        {
            HttpClient clientCabinets = new HttpClient();
            var response = await clientCabinets.GetAsync(adresseCabinets);
            var json = await response.Content.ReadAsStringAsync();
            listeCabinets = JsonConvert.DeserializeObject<CabinetsList>(json);

            return listeCabinets;
        }
        #endregion
    }
}
