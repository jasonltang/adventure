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
                                name: "Elephant",
                                hitpoints: 40,
                                attack: 6,
                                defense: 1,
                                weapon: "Swinging Trunk",
                                victoryText: "You regret not having the chance to ride on the elephant.",
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
                                attack: 28,
                                defense: 8,
                                weapon: "Compassion",
                                victoryText: "You defeat Jane Goodall, but vow to protect the chimpanzees.",
                                gold: 70,
                                confidence: 70
                            )
                        };
                case 3:
                    return new List<Enemy>
                        {
                            new Enemy
                            (
                                name: "Mob of Student Activists",
                                hitpoints: 300,
                                attack: 30,
                                attackStdev: 70,
                                defense: 40,
                                weapon: "Political Slogans",
                                victoryText: "Without a mobilising leader, the students quickly get back to their studies.",
                                gold: 150,
                                confidence: 150
                            )
                        };
                case 4:
                    return new List<Enemy>
                        {
                            new Enemy
                            (
                                name: "Adolf Hitler",
                                hitpoints: 100,
                                attack: 100,
                                attackStdev: 75,
                                defense: 100,
                                weapon: "Mein Kampf",
                                victoryText: "Well done, you've just resolved the Grandfather paradox.",
                                gold: 310,
                                confidence: 310
                            )
                        };
                case 5:
                    return new List<Enemy>
                        {
                            new Enemy
                            (
                                name: "White Whale",
                                hitpoints: 10000,
                                attack: 400,
                                attackStdev: 60,
                                defense: -200,
                                weapon: "Flailing Tail",
                                victoryText: "You have killed the White Whale and lived...",
                                gold: 0,
                                confidence: 10000
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
