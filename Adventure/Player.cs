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
            Area = 1;
            MaxHitpoints = 10;
            Hitpoints = 10;
            Attack = 1;
            Defense = 1;
            Weapon = 0;
            Armour = 0;
            Gold = 0;
            Confidence = 0;
            Deaths = 0;
            GameCompletions = 0;
            Location = Home.GetInstance();
            ID = Guid.NewGuid();
        }

        public string Name;
        public int Area;
        public int MaxHitpoints;
        public int Hitpoints;
        public int Attack;
        public int Defense;
        public int Weapon;
        public int Armour;
        public int Gold;
        public int Confidence;
        public int Deaths;
        public int GameCompletions;
        public Location Location { get; set; }
        public Guid ID;
        public Random Rng = new Random((int)DateTime.Now.Ticks);

        // Called when final trial battle is beaten.
        public void Reset()
        {
            Area = 1;
            MaxHitpoints = 10;
            Hitpoints = 10;
            Attack = 1;
            Defense = 1;
            Weapon = 0;
            Armour = 0;
            Gold = 0;
            Location = Home.GetInstance();
        }
    }
}
