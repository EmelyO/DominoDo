
namespace DominoDO.Model
{
    public class Game
    {
        public int GameId { get; set; }
        public int PlayerNumber { get; set; }
        public int ObjectiveScore { get; set; }
        public string State { get; set; } = "in_progress";
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public required string Modality { get; set; }
        public bool SimpleMode { get; set; }
        public int? WinningTeamId { get; set; }
        public int? WinningPlayerId { get; set; }
        public string GamesRowguid { get; set; } = Guid.NewGuid().ToString();
    }
}
