using superautomachines.commands;
using superautomachines.commands.data;
using superautomachines.game;

public class NewRound : ICommand
{
    public CommandResponse Execute(CommandArgs args = null)
    {
        Round.NewRound();
        return CommandResponse.Successfull;
    }
}