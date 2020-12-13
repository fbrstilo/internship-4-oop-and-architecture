
namespace InternshipDungeonCrawler.Data.Models.Player
{
    public class Ranger : Player
    {
        public Ranger()
        {
            MaxHealth *= 2;
            Damage *= 2;
        }
        public int CritChance { get; set; } = 10;
        public int StunChance { get; set; } = 10;
    }
}