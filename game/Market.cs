using System.Security.Cryptography;
using superautomachines.machines;

namespace superautomachines.game;

public class Market 
{
    public List<Machine> Machines { get; set; } = new();
    public static Market crr = null;
    public static Market Current {
        get
        {
            if(crr == null)
            {
                crr = new Market();
                crr.SetMachines();
            }

            return crr;
        }
    }

    public static Market NewMarket()
    {
        crr = new Market();
        crr.SetMachines();

        return Current;
    }

    public void SetMachines()
    {
        Machines = TeamGenerator.Generate(3);
    }

    public int BuyMachine(Machine m)
    {
        if(!Machines.Contains(m))
            return 0;

        Machines.Remove(m);

        return m.Price;
    }
}