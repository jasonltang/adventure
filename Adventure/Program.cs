using System;
using System.IO;

namespace Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists("RestSharp.dll") || !File.Exists("Newtonsoft.Json.dll"))
            {
                Console.WriteLine("RestSharp.dll and Newtonsoft.Json.dll are needed to play the game.");
                Console.WriteLine("Please extract them from the zip into the same folder as the exe.");
                Console.ReadKey();
                return;
            }
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
