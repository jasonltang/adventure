using System.Collections.Generic;
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

        public override string GetText()
        {
            return "Return home";
        }

        public override List<IAction> AllowedActions { get
            {
                return new List<IAction>()
                {
                    new ChangeLocationAction(Arena.GetInstance()),
                    new NapAction(),
                    new ViewStatsAction(),
                    new ChangeLocationAction(Shop.GetInstance()),
                    new ChangeLocationAction(Trial.GetInstance()),
                    new ViewHighScoresAction(),
                    new UploadHighScoreAction(),
                    new ChangeNameAction(),
                    new SaveAction(),
                    new LoadAction(),
                    new AboutAction(),
                };
            }
        }
    }
}
