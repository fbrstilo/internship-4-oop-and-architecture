
using InternshipDungeonCrawler.Data.Models.Monsters;
using System;

namespace InternshipDungeonCrawler.Data.Models.Player
{
    public class Warrior : Player
    {
        public Warrior()
        {
            MaxHealth *= 3;
        }
        public override void Attack(Player Player, Monster Enemy)
        {
            var done = false;
            while (!done)
            {
                Console.WriteLine("Select your move:" +
                    "\n1 - Normal attack" +
                    "\n2 - Rage attack (-20% player HP to do double damage)");
                var userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    base.Attack(Player, Enemy);
                    done = true;
                }
                else if (userInput == "2")
                {
                    Enemy.Health -= 2 * Player.Damage;
                    Console.WriteLine("You attacked the " + Enemy.Name + " and caused " + 2 * Player.Damage + " damage points");
                    Console.WriteLine("You were damaged for " + (int)(Player.MaxHealth * 0.15) + " Health points");
                    Player.CurrentHealth -= (int)(Player.MaxHealth * 0.15);
                    done = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please try again");
                }
            }
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n";
        }
    }
}