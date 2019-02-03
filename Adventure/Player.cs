using System;
using Adventure.Locations;

namespace Adventure
{

    public class Player // Singleton
    {
        private static Player _instance;
        public static Player GetInstance()
        {
            if (_instance == null) _instance = new Player();
            return _instance;
        }
        private Player()
        {
            Name = "Player";
            MaxHitpoints = 10;
            Hitpoints = 10;
            Attack = 1;
            Defense = 0;
            Gold = 0;
            Deaths = 0;
            //Weapon = 0;
            //Armour = 0;
            Location = Home.GetInstance();
            ID = Guid.NewGuid();
            Console.WriteLine(Location.LocationText);
        }

        public string Name;
        public int MaxHitpoints;
        public int Hitpoints;
        public int Attack;
        public int Defense;
        public int Gold;
        public int Deaths;
        //int Weapon { get; set; }
        //int Armour { get; set; }
        public Location Location { get; set; }
        public Guid ID;
        public Random Rng = new Random((int)DateTime.Now.Ticks);
    }
}
