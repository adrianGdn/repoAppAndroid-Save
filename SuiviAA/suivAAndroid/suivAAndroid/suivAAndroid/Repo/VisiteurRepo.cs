using SQLite.Net.Async;
using SQLite.Net.Interop;
using suivAAndroid.Models;
using suivAAndroid.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivAAndroid.Repository
{
    class VisiteurRepo
    {
        private SQLiteAsyncConnection _connection;

        public async Task InitialyzeAsync(string chemin, ISQLitePlatform sqlitePlatform)
        {
            _connection = SQLiteDB.GetConnection(chemin, sqlitePlatform);

            //Crée la table Visiteur si nécessaire
            await _connection.CreateTableAsync<Visiteur>();
        }

        public async Task<Visiteur> CreateAsync(string nom, string prenom, string login, string mdp, string adresse, string cp, string ville, string DateEmbauche)
        {
            var entity = new Visiteur(nom, prenom, login, mdp, adresse, cp, ville, DateEmbauche);

            var count = await _connection.InsertAsync(entity);
            return (count == 1) ? entity : null;
        }

        public async Task<IEnumerable<Visiteur>> GetAllAsync()
        {
            var entities = await _connection.Table<Visiteur>().ToListAsync();
            return entities;
        }
    }
}
