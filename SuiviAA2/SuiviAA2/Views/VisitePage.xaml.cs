using SuiviAA2.Model;
using SuiviAA2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SuiviAA2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VisitePage : ContentPage
    {
        public VisitePage()
        {
            InitializeComponent();
            BindingContext = new VisiteVM();
        }
    }
}
