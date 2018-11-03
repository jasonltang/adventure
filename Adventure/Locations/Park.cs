using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventure.Actions;

namespace Adventure.Locations
{
    class Park : Location
    {
        private static Park _instance;
        public static Park GetInstance()
        {
            if (_instance == null) _instance = new Park();
            return _instance;
        }
        private Park()
        {

        }

        public override string LocationText { get { return "You are at the park. The fresh air and cool breeze feels good."; } }

        public override List<IAction> AllowedActions
        {
            get
            {
                return new List<IAction>()
                {
                    new ChangeLocationAction(Home.GetInstance()),
                    new ChangeLocationAction(new Battle()),
                    new ViewStatsAction()
                };
            }
        }
    }
}
