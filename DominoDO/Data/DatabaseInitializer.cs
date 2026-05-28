using Dapper;

namespace DominoDO.Data
{
    public class DatabaseInitializer
    {
        private readonly DatabaseConnection _connection;

        public DatabaseInitializer(DatabaseConnection connection)
        {
            _connection = connection; 
        }


        public async Task InitAsync()
        {
            using var conn = _connection.GetConnection();

            await conn.ExecuteAsync(@"
            CREATE TABLE IF NOT EXISTS Players(
            PlayerId INTEGER PRIMARY KEY AUTOINCREMENT,
            PlayerName TEXT NOT NULL,
            PlayerCreationDate TEXT DEFAULT (datetime('now')),
            PlayerRowguid TEXT NOT NULL UNIQUE DEFAULT (upper(hex(randomblob(16))))
            );");

            await conn.ExecuteAsync(@"
            CREATE TABLE IF NOT EXISTS Teams(
            TeamId INTEGER PRIMARY KEY AUTOINCREMENT,
            TeamName TEXT NOT NULL,
            TeamCreationDate TEXT DEFAULT (datetime('now')),
            TeamRowguid TEXT NOT NULL UNIQUE DEFAULT (upper(hex(randomblob(16))))
            );");

            await conn.ExecuteAsync(@"
            CREATE TABLE IF NOT EXISTS TeamPlayers(
            TeamPlayersId INTEGER PRIMARY KEY AUTOINCREMENT,
            TeamId INTEGER NOT NULL REFERENCES Teams(TeamId),
            PlayerId INTEGER NOT NULL REFERENCES Players(PlayerId),
            TeamPlayersRowguid TEXT NOT NULL UNIQUE DEFAULT (upper(hex(randomblob(16))))
            );");

            await conn.ExecuteAsync(@"
            CREATE TABLE IF NOT EXISTS Games(
            GameId INTEGER PRIMARY KEY AUTOINCREMENT,
            PlayerNumber INTEGER NOT NULL,
            ObjectiveScore INTEGER NOT NULL,
            State TEXT DEFAULT 'in_progress',
            StartDate TEXT DEFAULT (datetime('now')),
            EndDate TEXT,
            Modality TEXT NOT NULL,
            SimpleMode INTEGER NOT NULL DEFAULT 0,
            WinningTeamId INTEGER REFERENCES Teams(TeamId),
            WinningPlayerId INTEGER REFERENCES Players(PlayerId),
            GamesRowguid TEXT NOT NULL UNIQUE DEFAULT (upper(hex(randomblob(16))))
            );");

            await conn.ExecuteAsync(@"
            CREATE TABLE IF NOT EXISTS GameDetail(
            GameDetailId INTEGER PRIMARY KEY AUTOINCREMENT,
            GameId INTEGER REFERENCES Games(GameId),
            TeamId INTEGER REFERENCES Teams(TeamId),
            PlayerId INTEGER REFERENCES Players(PlayerId),
            TotalPoints INTEGER DEFAULT 0,
            IsWinner INTEGER DEFAULT 0,
            GameDetailRowguid TEXT NOT NULL UNIQUE DEFAULT (upper(hex(randomblob(16))))
            );");

            await conn.ExecuteAsync(@"
            CREATE TABLE IF NOT EXISTS Rounds(
            RoundId INTEGER PRIMARY KEY AUTOINCREMENT,
            GameId INTEGER NOT NULL REFERENCES Games(GameId),
            RoundNumber INTEGER NOT NULL,
            DateTime TEXT DEFAULT (datetime('now')),
            RoundRowguid TEXT NOT NULL UNIQUE DEFAULT (upper(hex(randomblob(16))))
            );");

            await conn.ExecuteAsync(@"
            CREATE TABLE IF NOT EXISTS PointsRound(
            PointsRoundId INTEGER PRIMARY KEY AUTOINCREMENT,
            RoundId INTEGER NOT NULL REFERENCES Rounds(RoundId),
            GameDetailId INTEGER NOT NULL REFERENCES GameDetail(GameDetailId),
            Points INTEGER NOT NULL,
            AccumulatedPoints INTEGER NOT NULL,
            PointsRoundRowguid TEXT NOT NULL UNIQUE DEFAULT (upper(hex(randomblob(16))))
            );");
        }
    }
}
