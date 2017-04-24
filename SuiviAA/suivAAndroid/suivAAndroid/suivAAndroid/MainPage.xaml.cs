using suivAAndroid.Models;
using suivAAndroid.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace suivAAndroid
{

    public partial class MainPage : ContentPage
    {
        LoginViewModel vm = new LoginViewModel();
        public MainPage()
        {
            InitializeComponent();
            //this.BackgroundImage = "laboratoire.jpg";
            //définit le contexte dans lequel les informations passées dans les controles login et mdp sont récupérés.            
            BindingContext = vm;
        }

        //appelle la méthode de validation de la connexion du user en fction des users en base
        private void connexion_click(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(async () =>
                {
                    await vm.Connexion();
                });
        }

        #region btn_Changer vue
        // bouton change de vue
       private void ChangerVue(object sender, EventArgs e) // passe à la vue 2 pour test sans besoin connexion
        {
            App.Current.MainPage = new NavigationPage(new CreerVisite()); // permet de passer de la vue 1 à la vue 2
        }
        #endregion
    }
}
