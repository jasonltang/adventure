using Adventure.Locations;

namespace Adventure.Actions
{
    public class ChangeLocationAction : IAction
    {
        private Location _location;
        public string GetText()
        {
            return _location.GetType().Name;
        }
        public ChangeLocationAction(Location location)
        {
            _location = location;
        }
        public void Execute()
        {
            Player.GetInstance().Location = _location;
            _location.PrintText();
        }
    }
}
