using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Enemies
{
    public abstract class Enemy
    {
        public abstract string Name { get; }
        public abstract int Hitpoints { get; set; }
        public abstract int Attack { get; }
        public abstract int Defense { get; }
        public abstract string VictoryStatement { get; }
    }
}
