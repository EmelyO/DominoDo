
namespace DominoDO.Model
{
    public class GameDetail
    {
        public int GameDetailId { get; set; }
        public int GameId { get; set; }
        public int? TeamId { get; set; }
        public int? PlayerId { get; set; }
        public int TotalPoints { get; set; }
        public bool IsWinner { get; set; }
        public string GameDetailRowguid { get; set; } = Guid.NewGuid().ToString();
    }
}
