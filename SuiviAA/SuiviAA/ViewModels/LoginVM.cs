using Newtonsoft.Json;
using SuiviAA.JsonModel;
using SuiviAA.Services;
using SuiviAA.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static SuiviAA.ViewModels.BaseVM;

namespace SuiviAA.ViewModels
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
        public static ActeurJson acteurJson = new ActeurJson();

        #endregion
        #region methods
        public async Task Connexion()
        {
            // on met en place un try catch pour déceler toute erreur dans la procédure de connexion
            try
            {
                //instanciation du client http qui envoi un header json
                HttpClientService clientActeur = new HttpClientService();

                //désérialisation dans un obj acteur json
                
                acteurJson = JsonConvert.DeserializeObject<ActeurJson>(await clientActeur.loadActeur(Login, Pass));
                //Passerelle.setUserId(acteurJson.Acteur.id);
                //Passerelle.loadListCabinet();
                //Passerelle.loadListVisite();
                //Passerelle.loadListMedecin();

                //on vérifie les informations de connexion du user (ici cela se ait avec oldMdp car pas d'implémentation du SHA1 actuellement en Xamarin, auquel cas nous aurions converti le contenu du champ pass en sha1 puis vérification avec le champ mdp de l'acteur)
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
