using Microsoft.Data.Sqlite;

namespace DominoDO.Data
{
    public class DatabaseConnection
    {
        private readonly string _connectionString;

        public DatabaseConnection()
        {
            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "dominodo.db");
            _connectionString = $"Data Source={dbPath}";

        }

        public SqliteConnection GetConnection() 
        { 
            var conn = new SqliteConnection(_connectionString);
            conn.Open();
            return conn;
        
        }
    }
}

