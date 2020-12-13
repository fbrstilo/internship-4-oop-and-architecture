
namespace InternshipDungeonCrawler.Data.Models.Player
{
    public class Player
    {
        public string Name { get; set; }
        public int MaxHealth { get; set; } = 50;
        public int CurrentHealth { get; set; } = 50;
        public int ExperiencePoints { get; set; } = 0;
        public int CurrentLevel { get; set; } = 1;
        public int Damage { get; set; } = 10;

        public void HealthRegen(Player player)
        {
            if (player.CurrentHealth < player.MaxHealth)
            {
                player.CurrentHealth += (int)(player.MaxHealth * 0.25);
            }
        }
    }
}
