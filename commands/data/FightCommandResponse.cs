using superautomachines.commands.data;
using superautomachines.machines;

public class FightCommandResponse : CommandResponse
{
    public Machine Player;
    public Machine Opponent;
    public Machine Winner;
    public FightCommandResponse(Machine player, Machine opponent, Machine winner, bool success = true) : base(success)
    {
        Player = player;
        Opponent = opponent;
        Winner = winner;
    }
}