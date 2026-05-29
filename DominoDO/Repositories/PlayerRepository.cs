
using DominoDO.Repositories.Interfaces;
using Dapper;
using DominoDO.Data;
using DominoDO.Model;

namespace DominoDO.Repositories
{
    public class PlayerRepository: IPlayerRepository
    {
        private readonly DatabaseConnection _databaseConnection;

        public PlayerRepository(DatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
            
        }

        public async Task<IEnumerable<Player>> GetPlayersAsync()
        {
            using var conn = _databaseConnection.GetConnection();
            return await conn.QueryAsync<Player>("Select * from Players order by PlayerName");
        }

        public async Task<Player?> GetPlayerById(int id)
        {
            using var conn = _databaseConnection.GetConnection();
            return await conn.QuerySingleOrDefaultAsync<Player>("Select * from Players where PlayerId = @PlayerId", new { PlayerId = id });
        }

        public async Task<int> InsertPlayer(Player player)
        {
            using var conn = _databaseConnection.GetConnection();
            return await conn.ExecuteScalarAsync<int>(@"Insert into Players (PlayerName, PlayerRowguid) 
            values (@PlayerName, @PlayerRowguid);", player);
        }

        public async Task<int> UpdatePlayer(Player player)
        {
            using var conn = _databaseConnection.GetConnection();
            int consulta = await conn.ExecuteAsync(@"Update Players 
            set PlayerName = @PlayerName 
            where PlayerRowguid = @PlayerRowguid", player);

            return consulta;
        }

        public async Task<int> DeletePlayer(int id)
        {
            using var conn = _databaseConnection.GetConnection();

            int delete = await conn.ExecuteAsync("Delete from Players where PlayerId = @PlayerId", new {PlayerId = id});

            return delete;
        }
    }
}
