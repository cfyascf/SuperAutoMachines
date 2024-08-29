using superautomachines.commands.data;

public class RoundCommandResponse : CommandResponse
{
    public RoundResult RoundResult { get; set; }
    public RoundCommandResponse(bool success, RoundResult result) : base(success)
    {
        RoundResult = result;
    }
}