using System.Collections.Generic;
using Adventure.Actions;

namespace Adventure.Locations
{
    // Shouldn't really be called the Park anymore since that's the level 1 theme only.
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

        public override string GetText()
        {
            return "Go adventuring";
        }

        public override string LocationText {
            get
            {
                switch(Player.GetInstance().Area)
                {
                    case 1:
                        return "You are at the park. The fresh air and cool breeze feels good.";
                    case 2:
                        return "You are in a forest. There are animals everywhere.";
                    case 3:
                        return "You are in a university. You're so glad you decided to become an adventurer instead.";
                    case 4:
                        return "You are at the jail. There are criminals everywhere.";
                    case 5:
                        return "You are in the Land of Dreams. You are vaguely reminded of your own dreams.";
                    default:
                        return "Some other location text, e.g. shopping mall";
                }
            }
        }

        public override List<IAction> AllowedActions
        {
            get
            {
                return new List<IAction>()
                {
                    new ChangeLocationAction(new ParkBattle()),
                    new NapAction(),
                    new ViewStatsAction(),
                    new ChangeLocationAction(Home.GetInstance()),
                };
            }
        }
    }
}
