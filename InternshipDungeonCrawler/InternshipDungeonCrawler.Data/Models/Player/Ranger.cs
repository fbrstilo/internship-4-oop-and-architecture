
namespace InternshipDungeonCrawler.Data.Models.Player
{
    public class Ranger : Player
    {
        public Ranger()
        {
            MaxHealth = MaxHealth * 2;
            Damage = Damage * 2;
        }
        public int CritChance { get; set; } = 10;
        public int StunChance { get; set; } = 10;
    }
}
