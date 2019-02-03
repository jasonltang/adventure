namespace Adventure.Actions
{
    public interface IAction
    {
        string GetText();
        void Execute();
    }
}
