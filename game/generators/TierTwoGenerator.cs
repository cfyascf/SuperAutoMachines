using superautomachines.machines;

public static class TierTwoGenerator
{
    public static List<Machine> Possibilities { get; set; } = new();
    public static void SetPossibilities()
    {
        Possibilities.Add(new ColumnDrill());
        Possibilities.Add(new IndustrialGasOven());
        Possibilities.Add(new FlatGrinding());
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