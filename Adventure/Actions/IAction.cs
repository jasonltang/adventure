using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventure.Locations;

namespace Adventure.Actions
{
    public interface IAction
    {
        string GetText();
        void Execute();
    }
}
