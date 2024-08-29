namespace superautomachines.machines;

public abstract class Machine
{
    public string Name { get; set; }
    public int Level { get; set; } = 1;
    public int Experience { get; set; } = 1;
    public int Tier { get; set; }
    public int Attack { get; set; }
    public int Life { get; set; }

    public int Price { get; set; } = 3;

    public Machine(int tier, int attack, int life, string name)
    {
        Tier = tier;
        Attack = attack;
        Life = life;
        Name = name;
    }

    public RoundResult Fight(Machine enemy)
    {
        enemy.Life -= Attack;
        Life -= enemy.Attack;

        if(Life <= 0)
            return RoundResult.loss;

        if(enemy.Life <= 0)
            return RoundResult.win;

        return RoundResult.even;
    }

    // public abstract void ApplyBuff();
}