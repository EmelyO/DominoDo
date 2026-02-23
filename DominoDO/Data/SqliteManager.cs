using DominoDO.Model;
using SQLite;

namespace DominoDO.Data
{
    public class SqliteManager
    {
        private static SQLiteAsyncConnection? _database;

        public static async Task<SQLiteAsyncConnection> GetConnectionAsync()
        {
            if (_database != null)
                return _database;

            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "domino.db3");
            _database = new SQLiteAsyncConnection(dbPath);

            await _database.CreateTableAsync<ScoreTemp>();

            return _database;
        }
    }
}

