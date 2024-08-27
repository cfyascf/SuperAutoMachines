namespace superautomachines.game;
using superautomachines.machines;

public class Team
{
    private List<Machine> Comp { get; set; } = new();

    public void Build()
    {
        Random seed = new Random();
        var rnd = seed.Next(1, 7);

        switch(rnd)
        {
            case 1:
                
                break;
        }
    }

    public void AddMachine(Machine m)
    {
        if(Comp.Count == 5)
            throw new Exception("Team only accepts at max 5 machines.");
        
        Comp.Add(m);
    }
}