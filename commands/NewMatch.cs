using superautomachines.commands;
using superautomachines.game;
using superautomachines.commands.data;

public class NewMatch : ICommand
{
    public CommandResponse Execute(CommandArgs args)
    {
        Match.NewMatch();
        return CommandResponse.Successfull;
    }
}