using SQLite.Net;
using SQLite.Net.Async;
using SQLite.Net.Interop;
using suivAAndroid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivAAndroid.SQLite
{
    class SQLiteDB
    {
        public static SQLiteAsyncConnection GetConnection(string chemin, ISQLitePlatform sqlitePlatform)
        {
            var schemaConnection = new Func<SQLiteConnectionWithLock>(() => new SQLiteConnectionWithLock(sqlitePlatform, new SQLiteConnectionString(chemin, storeDateTimeAsTicks: false)));
            return new SQLiteAsyncConnection(schemaConnection);
        }
    }
}
