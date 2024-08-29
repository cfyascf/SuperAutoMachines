using superautomachines.machines;

public static class TierSixGenerator
{
    public static List<Machine> Possibilities { get; set; } = new();
    public static void SetPossibilities()
    {
        Possibilities.Add(new CNCPlasmaCutting());
    }
    public static Machine PickMachine()
    {
        if(Possibilities.Count == 0)
        {
            SetPossibilities();
        }
        
        Random seed = new Random();
        var rnd = seed.Next(0, Possibilities.Count);

        return Possibilities[rnd];
    }
}