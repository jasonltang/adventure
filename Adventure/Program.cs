// Todo list

// Upon finishing game, reset to area 1 and give 1.2x gold multiplier. Save 'game completions' in stats. Give a flat confidence bonus.

// Rebalance monsters

// Reassign keys ("Return home") at the end

// Potentially set enemy names and weapons as "a cat" and "its sharp claws"

// Set a different console colour for each level

//make savefile non-plain

using System;

namespace Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = Player.GetInstance();
            Console.ForegroundColor = Helpers.GetTextColourByArea(player.Area);
            Console.WriteLine(player.Location.LocationText);
            while (true)
            {
                InputReader.GetAction(player);
            }
        }
    }
}
