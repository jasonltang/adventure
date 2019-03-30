using Adventure.Locations;

namespace Adventure.Actions
{
    public class RunAction : IAction
    {
        string _runTo;

        public RunAction(string runTo)
        {
            _runTo = runTo;
        }

        public string GetText()
        {
            return "Run away";
        }

        public void Execute()
        {
            switch (_runTo)
            {
                case "Arena":
                    new ChangeLocationAction(Arena.GetInstance()).Execute();
                    break;
                case "Trial":
                    new ChangeLocationAction(Trial.GetInstance()).Execute();
                    break;
            }
            
        }
    }
}
