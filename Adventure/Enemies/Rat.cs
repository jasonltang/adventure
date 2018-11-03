using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Enemies
{
    class Rat : Enemy
    {
        string _name = "Rat";
        int _hitpoints = 5;
        int _attack = 1;
        int _defense = 0;
        string _victoryStatement = "Killing the tiny rat really makes you feel tough.";

        public override string Name { get { return _name; } }
        public override int Hitpoints { get { return _hitpoints; } set { _hitpoints = value; } }
        public override int Attack { get { return _attack; } }
        public override int Defense { get { return _defense; } }
        public override string VictoryStatement { get { return _victoryStatement; } }
    }
}
