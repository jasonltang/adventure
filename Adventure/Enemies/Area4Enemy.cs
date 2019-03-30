using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Enemies
{
    class Area4Enemy : IAreaEnemy
    {
        public List<Enemy> GetEnemyList()
        {
            return new List<Enemy>
                {
                    new Enemy
                    (
                        name: "Fare Evader",
                        hitpoints: 70,
                        attack: 35,
                        defense: 35,
                        weapon: "Recidivism",
                        victoryText: "He may have evaded fares, but he didn't evade you.",
                        gold: 95,
                        confidence: 37
                    ),
                    new Enemy
                    (
                        name: "Jaywalker",
                        hitpoints: 85,
                        attack: 45,
                        defense: 40,
                        weapon: "Confident Stride",
                        victoryText: "Trying to flee, the Jaywalker gets hit by a car.",
                        gold: 128,
                        confidence: 45
                    ),
                    new Enemy
                    (
                        name: "Embezzler",
                        hitpoints: 50,
                        attack: 45,
                        defense: 48,
                        weapon: "Illegal Wealth",
                        victoryText: "After knocking him out, you take some extra money from his wallet.",
                        gold: 335,
                        confidence: 39
                    ),
                    new Enemy
                    (
                        name: "Tax Evader",
                        hitpoints: 121,
                        attack: 59,
                        defense: 32,
                        weapon: "Offshore Accounts",
                        victoryText: "You expose his fake business for what it really is.",
                        gold: 273,
                        confidence: 56
                    ),
                    new Enemy
                    (
                        name: "Arsonist",
                        hitpoints: 114,
                        attack: 95,
                        defense: 43,
                        weapon: "Pyromania",
                        victoryText: "You grab the match out of his hand and extinguish it with your tongue.",
                        gold: 164,
                        confidence: 78
                    ),
                    new Enemy
                    (
                        name: "Robber",
                        hitpoints: 135,
                        attack: 78,
                        defense: 65,
                        weapon: "Imitation Pistol",
                        victoryText: "Apparently his 'handgun' was just a painted water pistol.",
                        gold: 137,
                        confidence: 66
                    ),
                    new Enemy
                    (
                        name: "Hacker",
                        hitpoints: 93,
                        attack: 63,
                        defense: 55,
                        weapon: "Social Engineering Skills",
                        victoryText: "You delete his email and report him to your local administrator.",
                        gold: 240,
                        confidence: 34
                    ),
                    new Enemy
                    (
                        name: "Gang Leader",
                        hitpoints: 225,
                        attack: 80,
                        defense: 82,
                        weapon: "Knuckle Duster",
                        victoryText: "You shudder to think what would have happened if you'd been defeated.",
                        gold: 286,
                        confidence: 79
                    ),
                    new Enemy
                    (
                        name: "Pickpocket",
                        hitpoints: 112,
                        attack: 63,
                        attackStdev: 20,
                        defense: 40,
                        weapon: "Stealth",
                        victoryText: "Luckily he only got your fake wallet.",
                        gold: 127,
                        confidence: 47
                    ),
                    new Enemy
                    (
                        name: "Drug Smuggler",
                        hitpoints: 135,
                        attack: 87,
                        defense: 75,
                        weapon: "Big Suitcase",
                        victoryText: "You have inflicted a death sentence on this man.",
                        gold: 289,
                        confidence: 68
                    ),
                    new Enemy
                    (
                        name: "Serial Killer",
                        hitpoints: 246,
                        attack: 143,
                        defense: 62,
                        weapon: "Psychopathic Behaviours",
                        victoryText: "Finally he will kill no more.",
                        gold: 215,
                        confidence: 76
                    ),
                    new Enemy
                    (
                        name: "Terrorist",
                        hitpoints: 50,
                        attack: 225,
                        defense: 90,
                        weapon: "IED",
                        victoryText: "You have just saved hundreds of lives.",
                        gold: 412,
                        confidence: 95
                    ),
                };
        }
    }
}
