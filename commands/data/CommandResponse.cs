namespace superautomachines.commands.data;

public class CommandResponse
{
    public bool Success { get; set; }

    public CommandResponse(bool success)
    {
        Success = success;
    }

    public static readonly CommandResponse Successfull = new(true);
    public static readonly CommandResponse Failed = new(false);
}