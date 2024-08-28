using superautomachines.commands;
using superautomachines.game;
using superautomachines.commands.data;

public class NewMatch : ICommand
{
    public CommandResponse Execute(CommandArgs args)
    {
        Match.Current.Start();
        return CommandResponse.Successfull;
    }
}