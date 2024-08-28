using System.Runtime.ConstrainedExecution;
using superautomachines.machines;

namespace superautomachines.game;

public class Round
{
    public List<Machine> Opponents { get; set; } = new();
    public List<Machine> Players { get; set; } = new();
    public int Coins { get; set; } = 10;
    private static Round crr = null;

    public static Round Current
    {
        get
        {
            crr ??= new Round();
            return crr;
        }
    }

    public static void NewRound()
    {
        crr = new Round();
    }

    public void BuildOpponentsComp()
    {
        Market.NewMarket();
        Random seed = new Random();
        var teamsize = seed.Next(3, 6);
        Opponents = TeamGenerator.Generate(teamsize);
    }

    public bool Play()
    {
        if(Match.Current.Life <= 0)
            return false;
        
        if(Round.Current.FightComp() == RoundResult.win)
            Match.Current.Trophies++;
        else
            Match.Current.Life--;

        return true;
    }

    public RoundResult FightComp()
    {
        while(true)
        {
            RoundResult result = RoundResult.even;
            Machine crrPlayer = Players.Last();
            Machine crrOpponent = Opponents.First();

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