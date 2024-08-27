using superautomachines.commands;
using superautomachines.game;
using superautomachines.machines;

public class AddTeamPlayer<T> : ICommand<T> 
    where T : Machine
{
    public void Execute(T machine)
    {
        Round.Current.AddTeamPlayer(machine);
    }
}