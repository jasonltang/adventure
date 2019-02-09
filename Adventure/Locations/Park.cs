using System.Collections.Generic;
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
                    new ChangeTrainingModeAction(),
                    new ViewStatsAction()
                };
            }
        }
    }
}
