using suivAAndroid.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivAAndroid.ViewModel 
{
    public partial class CreerVisiteViewModel : INotifyPropertyChanged
    {
        #region propriétés
        private Cabinet unCabinet;
        private Medecin unMedecin;

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
