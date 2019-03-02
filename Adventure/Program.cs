// Todo list
// add more monsters and bosses
// For each level: Set the savefile, set theme, set hitpoints, add monsters, add boss, set boss info, add weapons, adjust monsters as necessary

// fix trial info
// Remove experience and levelling as it's too confusing
//add more weapon and armour shop
//make savefile non-plain

using System;

namespace Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = Player.GetInstance();
            Console.WriteLine(player.Location.LocationText);
            while (true)
            {
                InputReader.GetAction(player);
            }
        }
    }
}
