
namespace DominoDO.Model
{
    public class PointsRound
    {
        public int PointsRoundId { get; set; }
        public int RoundId { get; set; }
        public int GameDetailId { get; set; }
        public int Points { get; set; }
        public int AccumulatedPoints { get; set; }
        public string PointsRoundRowguid { get; set; } = Guid.NewGuid().ToString();
    }
}
