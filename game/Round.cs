using System.Runtime.ConstrainedExecution;
using superautomachines.machines;

namespace superautomachines.game;

public class Round
{
    public List<Machine> Opponents { get; set; } = new();
    public List<Machine> Players { get; set; } = new();
    public int Coins { get; set; } = 10;
    public Market Market { get; set; } = null;
    private static Round crr = null;

    public static Round Current
    {
        get
        {
            crr ??= new Round();
            return crr;
        }
    }

    public static Round NewRound()
    {
        crr = new Round();
        
        return Current;
    }

    public void BuildOpponentsComp()
    {
        Random seed = new Random();
        var teamsize = seed.Next(3, 6);
        Opponents = TeamGenerator.Generate(teamsize);
    }

    public void AddTeamPlayer(Machine m)
    {
        if(Players.Count < 5)
            Coins -= Market.BuyMachine(m);
            Players.Add(m);
    }

    public RoundResult FightComp()
    {
        while(true)
        {
            RoundResult result = RoundResult.even;
            Machine crrPlayer = Players.Last();
            Machine crrOpponent = Opponents.Last();

            while(result == RoundResult.even)
            {
                result = crrPlayer.Fight(crrOpponent);

                if(result == RoundResult.win)
                {
                    Opponents.Remove(crrOpponent);
                }

                if(result == RoundResult.loss)
                {
                    Players.Remove(crrPlayer);
                }
            }

            if(Opponents.Count == 0)
                return RoundResult.win;

            if(Players.Count == 0)
                return RoundResult.loss;
        }
    }
}