using System.Collections.Generic;
using Adventure.Actions;

namespace Adventure.Locations
{
    class Arena : Location
    {
        private static Arena _instance;
        public static Arena GetInstance()
        {
            if (_instance == null) _instance = new Arena();
            return _instance;
        }
        private Arena()
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
                        return "You are in a university. Let's fight some students.";
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
                    new ChangeLocationAction(new ArenaBattle()),
                    new NapAction(),
                    new ViewStatsAction(),
                    new ChangeLocationAction(Home.GetInstance()),
                };
            }
        }
    }
}
