using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Json;
using System.IO;
using System.Windows.Input;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace suivAAndroid.Models
{
    public class Webservice
    {
        #region propriétés
        private string url;
        HttpClient client;

        public string URL
        {
            get { return url; }
            set { url = value; }
        }

        #endregion

        #region constructor
        public Webservice()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }
        #endregion

        #region methods

        public async Task<List<Cabinet>> RetrieveCabinetData()
        {
            var json = new List<Cabinet>();
            var uri = new Uri(string.Format("http://localhost/ppe3JoJuAd/gsbAppliFraisV2/w_cabinet.php", string.Empty));
            
            var response = await client.GetAsync(uri);
            if(response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                json = JsonConvert.DeserializeObject<List<Cabinet>>(content);
            }
            return json;
        }

        //private async Task<JsonValue> Connexion_Webservice(string url)
        //{
        //    // crée la requête HTTP
        //    HttpWebRequest requete = (HttpWebRequest)HttpWebRequest.Create(new Uri(url));
        //    requete.ContentType = "application/json";
        //    requete.Method = "GET";


        //    //Envoi la requête au serveur et attend la réponse
        //    using (WebResponse response = await requete.BeginGetResponse())
        //    {
        //        using (StreamReader sr = new StreamReader(response.GetResponseStream()))
        //        {
        //            string data = sr.ReadToEnd();
        //        }
        //    }
        //}

        //private async Task Recup_cabinet()
        //{
        //    string url = "http://localhost/ppe3JoJuAd/gsbAppliFraisV2/w_cabinet.php";
        //    HttpClient rq_cabinet = new HttpClient();

        //    var response = await rq_cabinet.GetAsync(new Uri(url));

        //    using (HttpWebResponse response = request.BeginGetResponse())
        //}

        //private async Task Recup_cabinet()
        //{
        //    string url = "http://localhost/ppe3JoJuAd/gsbAppliFraisV2/w_cabinet.php";
        //    HttpClient wb_cabinet = new HttpClient();
        //  var response = await wb_cb.GetAsync(new Uri(url));
        //    var cab_json = JsonConvert.DeserializeAnonymousType(await response.Content.ReadAsStringAsync(), definition);
        //}

        #endregion
    }
}
