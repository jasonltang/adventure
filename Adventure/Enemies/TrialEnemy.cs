using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Enemies
{
    class TrialEnemy : IAreaEnemy
    {
        int _area;
        public TrialEnemy(int area)
        {
            _area = area;
        }

        public List<Enemy> GetEnemyList()
        {
            switch (_area)
            {
                case 1:
                    return new List<Enemy>
                        {
                            new Enemy
                            (
                                name: "Salesman",
                                hitpoints: 30,
                                attack: 5,
                                defense: 3,
                                weapon: "High Pressure Sales Tactics",
                                victoryText: "After defeating this salesman, you are no longer afraid of salespeople.",
                                gold: 30,
                                confidence: 30
                            )
                        };
                case 2:
                    return new List<Enemy>
                        {
                            new Enemy
                            (
                                name: "Jane Goodall",
                                hitpoints: 65,
                                attack: 40,
                                defense: 20,
                                weapon: "Compassion",
                                victoryText: "You defeat Jane Goodall, but vow to study her works.",
                                gold: 70,
                                confidence: 70
                            )
                        };
                case 3:
                    return new List<Enemy>
                        {
                            new Enemy
                            (
                                name: "Boss 3",
                                hitpoints: 5,
                                attack: 1,
                                defense: 0,
                                weapon: "Big Teeth",
                                victoryText: "Killing the tiny rat really makes you feel tough.",
                                gold: 2,
                                confidence: 1
                            )
                        };
                default:
                    return new List<Enemy>
                        {
                            new Enemy
                            (
                                name: "Switch criterion out of bounds.",
                                hitpoints: 5,
                                attack: 1,
                                defense: 0,
                                weapon: "Big Teeth",
                                victoryText: "Killing the tiny rat really makes you feel tough.",
                                gold: 2,
                                confidence: 1
                            )
                        };
            }
        }
    }
}
