using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Enemies
{
    public class Enemy
    {
        public Enemy(string name, int hitpoints, int attack, int defense, string victoryText, int gold)
        {
            Name = name;
            Hitpoints = hitpoints;
            Attack = attack;
            Defense = defense;
            VictoryText = victoryText;
            Gold = gold;
        }

        public string Name { get; }
        public int Hitpoints { get; set; }
        public int Attack { get; }
        public int Defense { get; }
        public string VictoryText { get; }
        public int Gold { get; }
    }
}
