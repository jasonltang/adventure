using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Actions
{
    public class ViewStatsAction : IAction
    {
        public string GetText()
        {
            return "View player stats";
        }

        public void Execute()
        {
            var player = Player.GetInstance();
            Console.WriteLine($"Player stats:");
            Console.WriteLine($"Max hitpoints: {player.MaxHitpoints}");
            Console.WriteLine($"Hitpoints: {player.Hitpoints}");
            Console.WriteLine($"Attack: {player.Attack}");
            Console.WriteLine($"Defense: {player.Defense}");
        }
    }
}
