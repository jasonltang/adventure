using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            MaxHitpoints = 10;
            Hitpoints = 10;
            Attack = 1;
            Defense = 0;
            Gold = 0;
            Deaths = 0;
            //Weapon = 0;
            //Armour = 0;
            Location = Home.GetInstance();
            Console.WriteLine(Location.LocationText);
        }

        public int MaxHitpoints;
        public int Hitpoints;
        public int Attack;
        public int Defense;
        public int Gold;
        public int Deaths;
        //int Weapon { get; set; }
        //int Armour { get; set; }
        public Location Location { get; set; }
        public Random Rng = new Random((int)DateTime.Now.Ticks);
    }
}
