using suivAAndroid.Models;
using suivAAndroid.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivAAndroid
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        #region propriétés
        private string username;
        private string password;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Username"));
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        #endregion

        #region constructor
        public LoginViewModel()
        {

        }
        #endregion

        #region methodes

        public void CreerListeVisiteurDur(List<Visiteur> uneListe)
        {
            Visiteur unVisiteur = new Visiteur("Clooney", "George", "cgeorge", "azerty", "rue du port", "59", "lille", "20150713");
            uneListe.Add(unVisiteur);
        }
        public async Task Connexion()
        {
            List<Visiteur> uneListe = new List<Visiteur>();
            CreerListeVisiteurDur(uneListe);

            foreach (Visiteur unVisiteur in uneListe)
            {
                string login = unVisiteur.Login;
                string pass = unVisiteur.Mdp;

                if (login == username && pass == password)
                {
                    App.Current.MainPage = new CreerVisite();
                }
            }
        }
        #endregion

        #region tests
        Webservice testCabinet;
        
        
        #endregion
    }
}
