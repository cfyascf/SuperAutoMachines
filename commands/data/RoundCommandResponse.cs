using superautomachines.commands.data;

public class RoundCommandResponse : CommandResponse
{
    public RoundResult RoundResult { get; set; }
    public RoundCommandResponse(RoundResult result, bool success = true) : base(success)
    {
        RoundResult = result;
    }
}