using System;
using System.Collections.Generic;
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
