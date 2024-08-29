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

    public bool BuyMachine(Machine m)
    {
        if(!Machines.Contains(m))
            return false;

        if(Round.Current.Players.Count >= 5)
            return false;

        if(Round.Current.Coins < m.Price)
            return false;

        Round.Current.Coins -= m.Price;
        Round.Current.Players.Add(m);

        Machines.Remove(m);

        return true;
    }
}