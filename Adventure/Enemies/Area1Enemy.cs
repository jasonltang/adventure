using System.Collections.Generic;

namespace Adventure.Enemies
{
    class Area1Enemy : IAreaEnemy
    {
        public List<Enemy> GetEnemyList()
        {
            return new List<Enemy>
                {
                    new Enemy
                    (
                        name: "Ant",
                        hitpoints: 1,
                        attack: 1,
                        defense: 0,
                        weapon: "Division of Labour",
                        victoryText: "You kill the ant by just stepping on it.",
                        gold: 1,
                        confidence: 1
                    ),
                    new Enemy
                    (
                        name: "Tortoise",
                        hitpoints: 6,
                        attack: 1,
                        defense: 2,
                        weapon: "Slow and Steady",
                        victoryText: "You simply pick it up and toss it in the rubbish bin.",
                        gold: 5,
                        confidence: 1
                    ),
                    new Enemy
                    (
                        name: "Fish",
                        hitpoints: 3,
                        attack: 2,
                        defense: 0,
                        weapon: "Swimming Around",
                        victoryText: "It nearly tricked you into jumping into the pond, but luckily you were too smart for it.",
                        gold: 2,
                        confidence: 1
                    ),
                    new Enemy
                    (
                        name: "Swing Set",
                        hitpoints: 2,
                        attack: 5,
                        defense: 0,
                        weapon: "Swinging",
                        victoryText: "You step out of the way and put the swing back to equilibrium.",
                        gold: 3,
                        confidence: 1
                    ),
                    new Enemy
                    (
                        name: "Rat",
                        hitpoints: 4,
                        attack: 2,
                        defense: 0,
                        weapon: "Sharp Teeth",
                        victoryText: "Luckily you didn't catch a disease from it.",
                        gold: 3,
                        confidence: 1
                    ),
                    new Enemy
                    (
                        name: "Donkey",
                        hitpoints: 6,
                        attack: 2,
                        defense: 0,
                        weapon: "Triumphal Entry",
                        victoryText: "What is a donkey doing in a park?",
                        gold: 3,
                        confidence: 1
                    ),
                    new Enemy
                    (
                        name: "Baby",
                        hitpoints: 7,
                        attack: 2,
                        defense: 0,
                        weapon: "Crying",
                        victoryText: "You shut the unattended baby up by sticking a dummy in her mouth.",
                        gold: 3,
                        confidence: 1
                    ),
                    new Enemy
                    (
                        name: "Duck",
                        hitpoints: 3,
                        attack: 4,
                        defense: 0,
                        weapon: "Beak",
                        victoryText: "Craving Peking Duck, you put the duck in your bag.",
                        gold: 3,
                        confidence: 1
                    ),
                    new Enemy
                    (
                        name: "Dog",
                        hitpoints: 6,
                        attack: 3,
                        defense: 1,
                        weapon: "Loud Barking",
                        victoryText: "Its bark is worse than its bite.",
                        gold: 4,
                        confidence: 2
                    ),
                    new Enemy
                    (
                        name: "Homeless Guy",
                        hitpoints: 9,
                        attack: 2,
                        defense: 1,
                        weapon: "Nonsensical Yelling",
                        victoryText: "Finally you win the war of words.",
                        gold: 1,
                        confidence: 5
                    ),
                    new Enemy
                    (
                        name: "Pigeon",
                        hitpoints: 3,
                        attack: 4,
                        defense: 0,
                        weapon: "Random Flapping",
                        victoryText: "You kick the pigeon and it flies off.",
                        gold: 4,
                        confidence: 2
                    ),
                    new Enemy
                    (
                        name: "Cat",
                        hitpoints: 6,
                        attack: 10,
                        defense: 1,
                        weapon: "Sharp claws",
                        victoryText: "Curiosity killed the cat.",
                        gold: 8,
                        confidence: 5
                    ),
                    new Enemy
                    (
                        name: "Mother",
                        hitpoints: 10,
                        attack: 4,
                        defense: 3,
                        weapon: "Protectiveness",
                        victoryText: "Finally, she takes the stroller and flees the park.",
                        gold: 14,
                        confidence: 9
                    ),
                };
        }
    }
}
