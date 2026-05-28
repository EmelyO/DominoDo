
namespace DominoDO.Model
{
    public class TeamPlayers
    {
        public int TeamPlayersId { get; set; }
        public int TeamId { get; set; }
        public int PlayerId { get; set; }
        public string TeamPlayersRowguid { get; set; } = Guid.NewGuid().ToString();
    }
}
