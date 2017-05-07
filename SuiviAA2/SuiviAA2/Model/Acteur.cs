using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SuiviAA2.Model
{
    //    [Table("acteur")]
    //    public class Acteur
    //    {
    //        #region properties
    //        private string id;
    //        private string nom;
    //        private string prenom;
    //        private string login;
    //        private string mdp;
    //        private string adresse;
    //        private string cp;
    //        private string ville;
    //        private DateTime dateEmbauche;
    //        private int idTypeActeur;
    //        private string oldMdp;
    //        private string mail;
    //        private string questionSecrete;
    //        private int version;
    //        #endregion

    //        #region get/set
    //        [PrimaryKey, AutoIncrement, Column("id")]
    //        public string Id { get => id; set => id = value; }
    //        [Column("nom")]
    //        public string Nom { get => nom; set => nom = value; }
    //        [Column("prenom")]
    //        public string Prenom { get => prenom; set => prenom = value; }
    //        [Column("login")]
    //        public string Login { get => login; set => login = value; }
    //        [Column("mdp")]
    //        public string Mdp { get => mdp; set => mdp = value; }
    //        [Column("adresse")]
    //        public string Adresse { get => adresse; set => adresse = value; }
    //        [Column("cp")]
    //        public string Cp { get => cp; set => cp = value; }
    //        [Column("ville")]
    //        public string Ville { get => ville; set => ville = value; }
    //        [Column("dateEmbauche")]
    //        public DateTime DateEmbauche { get => dateEmbauche; set => dateEmbauche = value; }
    //        [Column("idTypeActeur")]
    //        public int IdTypeActeur { get => idTypeActeur; set => idTypeActeur = value; }
    //        [Column("oldMdp")]
    //        public string OldMdp { get => oldMdp; set => oldMdp = value; }
    //        [Column("mail")]
    //        public string Mail { get => mail; set => mail = value; }
    //        [Column("questionSecrete")]
    //        public string QuestionSecrete { get => questionSecrete; set => questionSecrete = value; }
    //        [Column("version")]
    //        public int Version { get => version; set => version = value; }
    //        #endregion

    //        #region methods
    //        //public async Task<Acteur> GetActeurAsync(string login,string pass)
    //        //{
    //        //    //url de récupération du json de l'acteur
    //        //    string urlActeur = "http://10.0.0.5/ppe3JoJuAd/gsbAppliFraisV2/webservices/w_visiteur.php" + "?" + "login=" + login +"&"+"pass="+pass;
    //        //    //instanciation du nouvel objet acteur
    //        //    Acteur unActeur = new Acteur();

    //        //    //instanciation du client http qui envoi un header json
    //        //    HttpClient clientActeur = new HttpClient();
    //        //    clientActeur.DefaultRequestHeaders.Accept.Clear();
    //        //    clientActeur.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

    //        //    //réponse à la requête Http
    //        //    var response = await clientActeur.GetAsync("visiteur");
    //        //    var jsonActeur = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
    //        //    unActeur = await Task.Run(() => JsonConvert.DeserializeObject<Acteur>(jsonActeur));

    //        //    return unActeur;
    //        //}
    //        #endregion
    //    }

    public class Acteur
    {
        [JsonProperty("id")]
        public string id { get; set; }
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
    }

    public class ActeurJson
    {
        [JsonProperty("Acteur")]
        public Acteur Acteur { get; set; }
    }
}
