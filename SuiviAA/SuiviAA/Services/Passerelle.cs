using Newtonsoft.Json;
using SuiviAA.JsonModel;
using SuiviAA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviAA.Services
{
    public static class Passerelle
    {
        #region propriétés
        public  static string userId;
        public static HttpClientService clientCabinet = new HttpClientService();
        public static List<Cabinet> listeDesCabinets = new List<Cabinet>();
        public static List<Medecin> listeDesMedecins = new List<Medecin>();
        public static List<Visite> listeDesVisites = new List<Visite>();
        #endregion

        public static void setUserId(string actorsId)
        {
           userId = actorsId;
        }

        public static async void loadListCabinet()
        {
            List<Cabinet> listeCabinets = new List<Cabinet>();
            CabinetJson cabinetJson = new CabinetJson();
            cabinetJson = JsonConvert.DeserializeObject<CabinetJson>(await clientCabinet.loadCabinets(userId));
            foreach (Cabinet unCabinet in cabinetJson)
            {
                listeCabinets.Add(unCabinet);
            }
            listeDesCabinets =  listeCabinets;
        }

        public static async void loadListVisite()
        {
            List<Visite> listeVisites = new List<Visite>();
            VisiteJson visiteJson = new VisiteJson();
            visiteJson = JsonConvert.DeserializeObject<VisiteJson>(await clientCabinet.loadCabinets(userId));
            foreach (Visite uneVisite in visiteJson)
            {
                listeVisites.Add(uneVisite);
            }
            listeDesVisites = listeVisites;
        }

        public static async void loadListMedecin()
        {
            List<Medecin> listeMedecin = new List<Medecin>();
            MedecinJson visiteMedecin = new MedecinJson();
            visiteMedecin = JsonConvert.DeserializeObject<MedecinJson>(await clientCabinet.loadCabinets(userId));
            foreach(Medecin unMedecin in visiteMedecin)
            {
                listeMedecin.Add(unMedecin);
            }
            listeDesMedecins = listeMedecin;
        }


    }
}
