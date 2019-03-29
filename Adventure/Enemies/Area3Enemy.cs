using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Enemies
{
    class Area3Enemy : IAreaEnemy
    {
        public List<Enemy> GetEnemyList()
        {
            return new List<Enemy>
                {
                    new Enemy
                    (
                        name: "Online Test",
                        hitpoints: 25,
                        attack: 10,
                        defense: 10,
                        weapon: "Timed Questions",
                        victoryText: "You ace the test. Too bad it's only worth 2% of your mark.",
                        gold: 20,
                        confidence: 15
                    ),
                    new Enemy
                    (
                        name: "Freshman",
                        hitpoints: 49,
                        attack: 20,
                        defense: 15,
                        weapon: "Excessive Friendliness",
                        victoryText: "You never had any desire to make friends with him.",
                        gold: 25,
                        confidence: 30
                    ),
                    new Enemy
                    (
                        name: "Major Essay",
                        hitpoints: 143,
                        attack: 20,
                        defense: 10,
                        weapon: "Daunting Word Count",
                        victoryText: "After pulling an all-nighter on the last day, you finally submit the essay.",
                        gold: 37,
                        confidence: 34
                    ),
                    new Enemy
                    (
                        name: "Mathematician",
                        hitpoints: 78,
                        attack: 25,
                        defense: 15,
                        weapon: "Hand-Waving Proof",
                        victoryText: "He doesn't seem so impressive after you confiscate his piece of chalk.",
                        gold: 45,
                        confidence: 35
                    ),
                    new Enemy
                    (
                        name: "International Student",
                        hitpoints: 74,
                        attack: 27,
                        defense: 11,
                        weapon: "Broken English",
                        victoryText: "After you knock him to the ground, you realise he just wanted to know the location of the nearest bathroom.",
                        gold: 43,
                        confidence: 29
                    ),
                    new Enemy
                    (
                        name: "Guest Lecturer",
                        hitpoints: 121,
                        attack: 22,
                        defense: 23,
                        weapon: "Academic Reputation",
                        victoryText: "Publishing a lot of papers unfortunately doesn't equate to success in a duel.",
                        gold: 67,
                        confidence: 32
                    ),
                    new Enemy
                    (
                        name: "Music Student",
                        hitpoints: 67,
                        attack: 32,
                        defense: 5,
                        weapon: "Trombone",
                        victoryText: "The music student has played his last note.",
                        gold: 70,
                        confidence: 43
                    ),
                    new Enemy
                    (
                        name: "Pokemon GO player",
                        hitpoints: 78,
                        attack: 37,
                        defense: 19,
                        weapon: "Lack of Situational Awareness",
                        victoryText: "Finally the Pokemon GO Player walks into a ditch, never to be seen again.",
                        gold: 90,
                        confidence: 47
                    ),
                    new Enemy
                    (
                        name: "Student Society Leader",
                        hitpoints: 90,
                        attack: 45,
                        defense: 21,
                        weapon: "Smooth Talking",
                        victoryText: "You usurp her as the leader of the student society.",
                        gold: 95,
                        confidence: 52
                    ),
                    new Enemy
                    (
                        name: "Final Exam",
                        hitpoints: 100,
                        attack: 50,
                        attackStdev: 50,
                        defense: 20,
                        weapon: "Normalised Grading",
                        victoryText: "You pass the exam, but you will have various recurring nightmares about the exam.",
                        gold: 120,
                        confidence: 35
                    ),
                    new Enemy
                    (
                        name: "Athlete",
                        hitpoints: 75,
                        attack: 40,
                        defense: 24,
                        weapon: "Cardiovascular Fitness",
                        victoryText: "You vow to get fit from now on.",
                        gold: 121,
                        confidence: 67
                    ),
                    new Enemy
                    (
                        name: "Professor of Philosophy",
                        hitpoints: 200,
                        attack: 44,
                        defense: 29,
                        weapon: "Rigorous Logical Arguments",
                        victoryText: "You defeat him by precisely refuting all his arguments.",
                        gold: 160,
                        confidence: 90
                    ),
                };
        }
    }
}
