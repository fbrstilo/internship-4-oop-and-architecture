
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

        public override void Attack()
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
                    base.Attack();
                    done = true;
                }
                else if (userInput == "2")
                {
                    DataStore.Enemy.Health -= 2 * DataStore.Player.Damage;
                    Console.WriteLine("You attacked the " + DataStore.Enemy.Name + " and caused " + 2 * DataStore.Player.Damage + " damage points");
                    Console.WriteLine("You were damaged for " + (int)(DataStore.Player.MaxHealth * 0.15) + " Health points");
                    DataStore.Player.Health -= (int)(DataStore.Player.MaxHealth * 0.15);
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