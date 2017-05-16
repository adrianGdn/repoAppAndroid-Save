using SuiviAA.Model;
using SuiviAA.Services;
using SuiviAA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SuiviAA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VisitePage : ContentPage
    {
        public VisitePage()
        {
            InitializeComponent();
            BindingContext = new VisitePage();
        }

        public void loadLists()
        {
            var cabPicker = new Picker();
            List<Cabinet> listeCabinets = new List<Cabinet>();
            cabPicker.ItemsSource = listeCabinets;

            var medPicker = new Picker();
            List<Medecin> listeMedecin = new List<Medecin>();
            medPicker.ItemsSource = listeMedecin;
        }
    }
}