﻿using System;
using System.Collections.Generic;
using Adventure.Actions;

namespace Adventure.Locations
{
    public abstract class Location
    {
        public abstract string LocationText { get; } 

        public abstract List<IAction> AllowedActions { get; }

        public virtual string GetText()
        {
            return GetType().Name;
        }

        public void PrintText()
        {
            if (LocationText != "")
            {
                Console.WriteLine(LocationText);
            }
        }
    }
}
