using superautomachines.machines;

public class BuyTeamPlayerArgs : CommandArgs
{
    public Machine NewMachine { get; set; }
    public BuyTeamPlayerArgs(Machine m, Type args = default) : base(args)
    {
        NewMachine = m;
    }
}