// Todo list
// Set a ceiling for leveling up, i.e. don't throw error when beating lv 10
// Add some more difficult monsters
// Remove experience and levelling as it's too confusing
// Add unit tests
// Integrate with Jenkins
// Add a player arena

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
