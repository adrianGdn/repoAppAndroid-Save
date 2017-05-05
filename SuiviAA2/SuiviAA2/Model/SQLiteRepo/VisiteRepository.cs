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

        public async Task AddNewVisiteAsync()
        {
            //ajouter méthode ajout visite
        }
    }
}
