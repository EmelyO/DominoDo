
namespace DominoDO.Model
{
    public class Round
    {
        public int RoundId { get; set; }
        public int GameId { get; set; }
        public int RoundNumber { get; set; }
        public DateTime DateTime { get; set; }
        public string RoundRowguid { get; set; } = Guid.NewGuid().ToString();
    }
}
