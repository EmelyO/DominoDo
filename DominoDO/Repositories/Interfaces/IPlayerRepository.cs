using DominoDO.Model;

namespace DominoDO.Repositories.Interfaces
{
    public interface IPlayerRepository
    {
        Task<IEnumerable<Player>> GetPlayersAsync();
        Task<Player?> GetPlayerById(int id);
        Task<int> InsertPlayer (Player player);
        Task<int> UpdatePlayer (Player player);
        Task<int> DeletePlayer (int id);
    }
}
