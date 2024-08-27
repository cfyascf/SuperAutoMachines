using System.Windows.Input;
using superautomachines.commands;
using superautomachines.game;

public class StartRound<T> : ICommand<T>
{
    public void Execute(T args = default)
    {
        Match.Current.Play();
    }
}