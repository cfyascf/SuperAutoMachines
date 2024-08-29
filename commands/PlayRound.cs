using superautomachines.commands;
using superautomachines.game;
using superautomachines.commands.data;

public class PlayRound : ICommand
{
    public CommandResponse Execute(CommandArgs args)
    {
        var success = Round.Current.Play();
        return new RoundCommandResponse(true, success);
    }
}