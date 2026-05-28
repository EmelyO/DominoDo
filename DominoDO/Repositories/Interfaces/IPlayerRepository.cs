using DominoDO.Model;

namespace DominoDO.Repositories.Interfaces
{
    public interface IPlayerRepository
    {
        Task<IEnumerable<Player>> GetPlayersAsync();
        Task<IEnumerable<Player>> GetPlayerById();
        Task<int> InsertPlayer (Player player);
        Task<int> UpdatePlayer (Player player);
        Task<int> DeletePlayer (Player player);
    }
}
