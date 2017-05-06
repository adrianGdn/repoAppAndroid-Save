using Newtonsoft.Json;
using SuiviAA2.Model;
using SuiviAA2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SuiviAA2
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new LoginVM();
        }

        private void btn_Connexion_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}
