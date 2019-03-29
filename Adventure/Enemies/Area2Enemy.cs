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
                        name: "Mushroom",
                        hitpoints: 6,
                        attack: 4,
                        defense: 2,
                        weapon: "Spores",
                        victoryText: "Even though it looks tasty, you avoid eating the mushroom.",
                        gold: 8,
                        confidence: 4
                    ),
                    new Enemy
                    (
                        name: "Monkey",
                        hitpoints: 12,
                        attack: 6,
                        defense: 2,
                        weapon: "Dexterity",
                        victoryText: "The monkey swings back into the branches.",
                        gold: 8,
                        confidence: 5
                    ),
                    new Enemy
                    (
                        name: "Falling Tree",
                        hitpoints: 4,
                        attack: 20,
                        defense: 0,
                        weapon: "Potential Energy",
                        victoryText: "Your reflexes allow you to jump out of the way.",
                        gold: 7,
                        confidence: 5
                    ),
                    new Enemy
                    (
                        name: "Hiker",
                        hitpoints: 20,
                        attack: 7,
                        defense: 2,
                        weapon: "Friendly Greeting",
                        victoryText: "Your reflexes allow you to jump out of the way.",
                        gold: 15,
                        confidence: 8
                    ),
                    new Enemy
                    (
                        name: "Fox",
                        hitpoints: 10,
                        attack: 8,
                        defense: 3,
                        weapon: "Slyness",
                        victoryText: "You are like the grapes, just out of reach for the fox.",
                        gold: 10,
                        confidence: 12
                    ),
                    new Enemy
                    (
                        name: "Eagle",
                        hitpoints: 8,
                        attack: 8,
                        defense: 8,
                        weapon: "Talons",
                        victoryText: "Finally the eagle falls out of the sky.",
                        gold: 8,
                        confidence: 20
                    ),
                    new Enemy
                    (
                        name: "Moose",
                        hitpoints: 22,
                        attack: 8,
                        defense: 3,
                        weapon: "Antlers",
                        victoryText: "The moose moos as it accepts the bad news.",
                        gold: 8,
                        confidence: 20
                    ),
                    new Enemy
                    (
                        name: "Snake",
                        hitpoints: 6,
                        attack: 10,
                        defense: 6,
                        weapon: "Constriction",
                        victoryText: "You shed its skin.",
                        gold: 11,
                        confidence: 17
                    ),
                    new Enemy
                    (
                        name: "Panda",
                        hitpoints: 50,
                        attack: 8,
                        defense: 0,
                        weapon: "Bamboo Shoots",
                        victoryText: "It goes back to eating its bamboo shoots.",
                        gold: 20,
                        confidence: 10
                    ),
                    new Enemy
                    (
                        name: "Bear",
                        hitpoints: 25,
                        attack: 7,
                        defense: 6,
                        weapon: "Claws",
                        victoryText: "There's a bear in there, and a chair as well.",
                        gold: 17,
                        confidence: 30
                    ),
                    new Enemy
                    (
                        name: "Koala",
                        hitpoints: 15,
                        attack: 20,
                        defense: 1,
                        weapon: "Cuteness",
                        victoryText: "You were unlucky to meet this koala during its 4 waking hours.",
                        gold: 23,
                        confidence: 9
                    ),
                    new Enemy
                    (
                        name: "Tiger",
                        hitpoints: 30,
                        attack: 17,
                        defense: 5,
                        weapon: "Camouflage",
                        victoryText: "Wow, that was scary.",
                        gold: 45,
                        confidence: 40
                    ),
                };
        }
    }
}
