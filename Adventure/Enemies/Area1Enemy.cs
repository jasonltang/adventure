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
                        hitpoints: 10,
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
                        hitpoints: 4,
                        attack: 2,
                        defense: 1,
                        weapon: "Swimming Around",
                        victoryText: "It nearly tricked you into jumping into the pond, but luckily you were too smart for it.",
                        gold: 2,
                        confidence: 1
                    ),
                    new Enemy
                    (
                        name: "Swing set",
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
                        attack: 4,
                        defense: 0,
                        weapon: "Sharp teeth",
                        victoryText: "Luckily you didn't catch a disease from it.",
                        gold: 4,
                        confidence: 1
                    ),
                    new Enemy
                    (
                        name: "Donkey",
                        hitpoints: 6,
                        attack: 2,
                        defense: 1,
                        weapon: "Triumphal Entry",
                        victoryText: "What is a donkey doing in a park?",
                        gold: 3,
                        confidence: 1
                    ),
                    new Enemy
                    (
                        name: "Baby",
                        hitpoints: 7,
                        attack: 3,
                        defense: 0,
                        weapon: "Crying",
                        victoryText: "Finally you stick a dummy in her mouth.",
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
                        hitpoints: 9,
                        attack: 4,
                        defense: 2,
                        weapon: "Loud barking",
                        victoryText: "Its bark is worse than its bite.",
                        gold: 4,
                        confidence: 2
                    ),
                    new Enemy
                    (
                        name: "Homeless guy",
                        hitpoints: 15,
                        attack: 2,
                        defense: 3,
                        weapon: "Nonsensical Yelling",
                        victoryText: "Finally you win the war of words.",
                        gold: 1,
                        confidence: 5
                    ),
                    new Enemy
                    (
                        name: "Pigeon",
                        hitpoints: 4,
                        attack: 7,
                        defense: 0,
                        weapon: "Random flapping",
                        victoryText: "You kick the pigeon and it flies off.",
                        gold: 4,
                        confidence: 2
                    ),
                    new Enemy
                    (
                        name: "Cat",
                        hitpoints: 8,
                        attack: 10,
                        defense: 1,
                        weapon: "Sharp claws",
                        victoryText: "You have no idea where this cat came from.",
                        gold: 10,
                        confidence: 5
                    ),
                    new Enemy
                    (
                        name: "Mother",
                        hitpoints: 20,
                        attack: 4,
                        defense: 4,
                        weapon: "Protectiveness",
                        victoryText: "Finally, she takes the stroller and flees the park.",
                        gold: 20,
                        confidence: 10
                    ),
                };
        }
    }
}
