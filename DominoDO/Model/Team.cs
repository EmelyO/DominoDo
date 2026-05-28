
namespace DominoDO.Model
{
    public class Team
    {
        public int TeamId { get; set; }
        public required string TeamName { get; set; }
        public DateTime TeamCreationDate { get; set; }
        public string TeamRowguid { get; set; } = Guid.NewGuid().ToString();
    }
}
