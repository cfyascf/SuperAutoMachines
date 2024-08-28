using superautomachines.commands;
using superautomachines.game;
using superautomachines.machines;
using superautomachines.commands.data;

public class BuyTeamPlayer : ICommand
{
    public CommandResponse Execute(CommandArgs args)
    {
        if (args is not BuyTeamPlayerArgs teamPlayerArgs)
            return CommandResponse.Failed;

        var success = Market.Current.BuyMachine(teamPlayerArgs.NewMachine);
        return new CommandResponse(success);
    }
}