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
            //Weapon = 0;
            //Armour = 0;
            Location = Home.GetInstance();
            Console.WriteLine(Location.LocationText);
        }

        public int MaxHitpoints;
        public int Hitpoints;
        public int Attack;
        public int Defense;
        //int Weapon { get; set; }
        //int Armour { get; set; }
        public Location Location { get; set; }
    }
}
