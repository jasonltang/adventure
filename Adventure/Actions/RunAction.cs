using Adventure.Locations;

namespace Adventure.Actions
{
    public class RunAction : IAction
    {
        public string GetText()
        {
            return "Run away";
        }

        public void Execute()
        {
            new ChangeLocationAction(Park.GetInstance()).Execute();
        }
    }
}
