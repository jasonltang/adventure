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
                        name: "Goldilocks",
                        hitpoints: 100,
                        attack: 90,
                        defense: 60,
                        weapon: "Bratty Behaviour",
                        victoryText: "The three bears thank you for your deed.",
                        gold: 200,
                        confidence: 200
                    ),
                    new Enemy
                    (
                        name: "Aleksandr Ivanovich Luzhin",
                        hitpoints: 150,
                        attack: 110,
                        defense: 80,
                        weapon: "King's Indian Attack",
                        victoryText: "You defeat Luzhin in a tactical game of chess.",
                        gold: 300,
                        confidence: 210
                    ),
                    new Enemy
                    (
                        name: "Mr Darcy",
                        hitpoints: 200,
                        attack: 130,
                        defense: 90,
                        weapon: "Pride",
                        victoryText: "You realised that you were unfairly prejudiced towards Mr Darcy.",
                        gold: 400,
                        confidence: 220
                    ),
                    new Enemy
                    (
                        name: "John Lennon",
                        hitpoints: 250,
                        attack: 150,
                        defense: 100,
                        weapon: "Imagination",
                        victoryText: "\"He's a bit of a dreamer\", you mumble to yourself.",
                        gold: 600,
                        confidence: 250
                    ),
                    new Enemy
                    (
                        name: "The Flash",
                        hitpoints: 300,
                        attack: 160,
                        defense: 130,
                        weapon: "Lightning Punch",
                        victoryText: "You bend spacetime and he crashes into the wall behind you.",
                        gold: 800,
                        confidence: 270
                    ),
                    new Enemy
                    (
                        name: "Mewtwo",
                        hitpoints: 400,
                        attack: 200,
                        defense: 130,
                        weapon: "Psychic",
                        victoryText: "You defeat him with your Bite attack.",
                        gold: 1000,
                        confidence: 300
                    ),
                    new Enemy
                    (
                        name: "Julius Caesar",
                        hitpoints: 450,
                        attack: 220,
                        defense: 150,
                        weapon: "Scathing Political Rhetoric",
                        victoryText: "As he falls to the ground, he drops a bowl of Caesar Salad.",
                        gold: 1300,
                        confidence: 330
                    ),
                    new Enemy
                    (
                        name: "Egyptian Mummy",
                        hitpoints: 550,
                        attack: 250,
                        defense: 160,
                        weapon: "Bandage Suffocation",
                        victoryText: "Underneath the bandages, the mummy is completely nude.",
                        gold: 1600,
                        confidence: 360
                    ),
                    new Enemy
                    (
                        name: "Darth Vader",
                        hitpoints: 600,
                        attack: 280,
                        defense: 170,
                        weapon: "Force Choke",
                        victoryText: "Darth Vader? More like Chad Vader.",
                        gold: 2000,
                        confidence: 400
                    ),
                    new Enemy
                    (
                        name: "Aeneas",
                        hitpoints: 650,
                        attack: 300,
                        defense: 190,
                        weapon: "Founder's Sword",
                        victoryText: "You have defeated the mighty leader.",
                        gold: 2500,
                        confidence: 450
                    ),
                    new Enemy
                    (
                        name: "Isaac Newton",
                        hitpoints: 750,
                        attack: 350,
                        defense: 200,
                        weapon: "Sword of Wisdom",
                        victoryText: "You can now stand on the shoulder of a giant.",
                        gold: 3500,
                        confidence: 500
                    ),
                    new Enemy
                    (
                        name: "Chuck Norris",
                        hitpoints: 900,
                        attack: 450,
                        defense: 200,
                        weapon: "Roundhouse Kick",
                        victoryText: "In mother Russia, you kill Chuck Norris!",
                        gold: 5000,
                        confidence: 600
                    ),
                };
        }
    }
}
