using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventure.Actions;

namespace Adventure.Locations
{
    class Home : Location
    {
        private static Home _instance;
        public static Home GetInstance()
        {
            if (_instance == null) _instance = new Home();
            return _instance;
        }
        private Home()
        {

        }

        public override string LocationText { get { return "You are at home. It is so nice..."; } }

        public override List<IAction> AllowedActions { get
            {
                return new List<IAction>()
                {
                    new ChangeLocationAction(Park.GetInstance()),
                    new ViewStatsAction(),
                    new NapAction(),
                    new SaveAction(),
                    new LoadAction()
                };
            }
        }
    }
}
