namespace superautomachines.machines;

public abstract class Machine
{
    public int Level { get; set; } = 1;
    public int Experience { get; set; } = 1;
    public int Tier { get; set; }
    public int Attack { get; set; }
    public int Life { get; set; }

    public int Price { get; set; } = 3;

    public Machine(int tier, int attack, int life)
    {
        Tier = tier;
        Attack = attack;
        Life = life;
    }
}