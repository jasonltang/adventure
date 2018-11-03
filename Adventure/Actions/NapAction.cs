using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Actions
{
    class NapAction : IAction
    {
        public string GetText()
        {
            return "Nap";
        }

        public void Execute()
        {
            var player = Player.GetInstance();
            player.Hitpoints = player.MaxHitpoints;
            Console.WriteLine("You take a nice long nap and feel very refreshed.");
        }
    }
}
