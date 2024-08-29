using System.Text.RegularExpressions;
using superautomachines.commands;
using superautomachines.commands.data;
using superautomachines.game;

public class PlayFight : ICommand
{
    public CommandResponse Execute(CommandArgs args = null)
    {
        var result = Round.Current.PlayFight();
        return new FightCommandResponse(result.player, result.opponent, result.winner);
    }
}