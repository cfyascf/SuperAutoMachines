using superautomachines.commands;
using superautomachines.game;

public class NewMatch<T> : ICommand<T>
{
    public void Execute(T args = default)
    {
        var match = Match.NewMatch();
        match.Start();
    }
}