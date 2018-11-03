using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventure.Actions;

namespace Adventure.Locations
{
    public abstract class Location
    {
        public abstract string LocationText { get; } 

        public abstract List<IAction> AllowedActions { get; }

        public virtual void PrintText()
        {
            Console.WriteLine(LocationText);
        }
    }
}
