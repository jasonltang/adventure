using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Enemies
{
    class Area2Enemy : IAreaEnemy
    {
        public List<Enemy> GetEnemyList()
        {
            return new List<Enemy>
                {
                    new Enemy
                    (
                        name: "Rat2",
                        hitpoints: 5,
                        attack: 1,
                        defense: 0,
                        weapon: "Big Teeth",
                        victoryText: "Killing the tiny rat really makes you feel tough.",
                        gold: 2,
                        confidence: 1
                    ),
                    new Enemy
                    (
                        name: "Bird2",
                        hitpoints: 2,
                        attack: 1,
                        defense: 0,
                        weapon: "Beak",
                        victoryText: "You pluck the last feather off the bird.",
                        gold: 1,
                        confidence: 1
                    ),
                };
        }
    }
}
