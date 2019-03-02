using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Enemies
{
    class Area5Enemy : IAreaEnemy
    {
        public List<Enemy> GetEnemyList()
        {
            return new List<Enemy>
                {
                    new Enemy
                    (
                        name: "Rat5",
                        hitpoints: 5,
                        attack: 1,
                        defense: 0,
                        weapon: "Big Teeth",
                        victoryText: "Killing the tiny rat really makes you feel tough.",
                        gold: 2,
                        confidence: 1
                    ),
                };
        }
    }
}
