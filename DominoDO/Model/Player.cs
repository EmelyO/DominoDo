
namespace DominoDO.Model
{
    public class Player
    {
        public int PlayerId { get; set; }
        public required string PlayerName { get; set; }
        public DateTime PlayerCreationDate { get; set; }
        public string PlayerRowguid { get; set; } = Guid.NewGuid().ToString();
    }
}
