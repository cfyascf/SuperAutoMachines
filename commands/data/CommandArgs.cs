public class CommandArgs
{
    Type Args { get; set; }

    public CommandArgs(Type args)
    {
        Args = args;
    }

    public static CommandArgs args = null;
}