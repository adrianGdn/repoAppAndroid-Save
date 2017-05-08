using Newtonsoft.Json;
using SuiviAA2.Model;
using SuiviAA2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static SuiviAA2.ViewModels.BaseVM;
using System.Security;
using System.Diagnostics;

namespace SuiviAA2.ViewModels
{
    public class LoginVM
    {
        #region properties
        public static string login;
        public static string pass;
        #endregion
        #region get/set
        public string Login { get => login; set => login = value; } // Recupère automatiquement la valeur du champ ent_login de la mainpage
        public string Pass { get => pass; set => pass = value; } // Recupère automatiquement la valeur du champ ent_mdp de la mainpage
        #endregion
        #region methods
        public async Task Connexion()
        {
            // on met en place un try catch pour déceler toute erreur dans la procédure de connexion
            try
            {
                // url de récupération du json de l'acteur
                string urlActeur = "http://10.0.0.5/ppe3JoJuAd/gsbAppliFraisV2/webservices/w_visiteur.php" + "?" + "login=" + Login + "&" + "pass=" + Pass;

                //instanciation du client http qui envoi un header json
                HttpClient clientActeur = new HttpClient();
                clientActeur.DefaultRequestHeaders.Accept.Clear();
                clientActeur.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //réponse à la requête Http
                var response = await clientActeur.GetAsync(urlActeur);
                var json = response.Content.ReadAsStringAsync().Result;
                var acteurJson = JsonConvert.DeserializeObject<ActeurJson>(json);

                //on vérifie les informations de connexion du user (ici cela se ait avec oldMdp car pas d'implémentation du SHA1 actuellement en Xamarin, auquel cas nous auions converti le contenu du champ pass en sha1 puis vérification avec le champ mdp de l'acteur)
                if (acteurJson.Acteur.login == login && acteurJson.Acteur.oldMdp == pass)
                {
                    App.Current.MainPage = new VisitePage();
                }
            }
            catch
            {
                await App.Current.MainPage.DisplayAlert("Impossible de se connecter", "L'authentification à échouée", "OK");
                return;
            }
            

        }

        #endregion

        #region Commands
        // ExecuteCOnnexion va appeler la fonction Connexion de LoginVM
        public ICommand ExecuteConnexion { get { return new RelayCommandAsync(x => Connexion()); } }

        


        #endregion
    }
}
