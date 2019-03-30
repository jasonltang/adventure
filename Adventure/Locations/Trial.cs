using System.Collections.Generic;
using Adventure.Actions;

namespace Adventure.Locations
{
    class Trial : Location
    {
        private static Trial _instance;
        public static Trial GetInstance()
        {
            if (_instance == null) _instance = new Trial();
            return _instance;
        }
        private Trial()
        {

        }

        public override string GetText()
        {
            return "Take trial";
        }

        public override string LocationText { get { return "You step into the dojo."; } }

        public override List<IAction> AllowedActions
        {
            get
            {
                return new List<IAction>()
                {
                    new ChangeLocationAction(new TrialBattle()),
                    new GetTrialInfoAction(),
                    new ViewStatsAction(),
                    new ChangeLocationAction(Home.GetInstance()),
                };
            }
        }
    }
}
