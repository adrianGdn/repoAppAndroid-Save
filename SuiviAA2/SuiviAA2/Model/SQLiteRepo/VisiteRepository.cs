using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;
using SQLite.Net.Interop;
using SQLite.Net.Async;

namespace SuiviAA2.Model.SQLiteRepo
{
    public class VisiteRepository
    {
        private SQLiteAsyncConnection dbConn;

        public string StatusMessage { get; set; }

        public VisiteRepository(ISQLitePlatform sqlitePlatform, string dbPath)
        {
            //initialise la connection à la base SQLite
            if(dbConn == null)
            {
                var connectionFunc = new Func<SQLiteConnectionWithLock>(() =>
                    new SQLiteConnectionWithLock
                    (
                        sqlitePlatform,
                        new SQLiteConnectionString(dbPath, storeDateTimeAsTicks: false)
                    ));

                dbConn = new SQLiteAsyncConnection(connectionFunc);
                dbConn.CreateTableAsync<Visite>(); //Crée la table visite
            }

        }

        public async Task AddNewVisiteAsync(int id,DateTime dateVisite,int estVisiteProgramme,string heureArriveeCabinet,string heureDebutEntretien,string heureDepartCabinet, int idMedecin,string idActeur)
        {
            //ajouter méthode ajout visite
            int result = 0;
            try
            {
                //insert une visite dans la table visite
                result = await dbConn.InsertAsync(new Visite { Id = id, DateVisite = dateVisite, EstVisiteProgramme = estVisiteProgramme, HeureArriveeCabinet = heureArriveeCabinet, HeureDebutEntretien = heureDebutEntretien, HeureDepartCabinet = heureDepartCabinet, IdMedecin = idMedecin, IdActeur = idActeur });
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Impossible d'insérer une visite");
            }
        }
    }
}
