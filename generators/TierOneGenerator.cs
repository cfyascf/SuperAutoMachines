using superautomachines.machines;

public static class TierOneGenerator
{
    public static List<Machine> Possibilities { get; set; } = new();
    public static void SetPossibilities()
    {
        Possibilities.Add(new Hammer());
        Possibilities.Add(new Screwdriver());
        Possibilities.Add(new Treadmill());
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