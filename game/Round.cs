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
        Current.BuildOpponentsComp();
        Market.NewMarket();
    }

    public void BuildOpponentsComp()
    {
        Market.NewMarket();
        Random seed = new Random();
        var teamsize = seed.Next(3, 6);
        Opponents = TeamGenerator.Generate(teamsize);
    }

    public SingleFightResult PlayFight()
    {
        RoundResult result = RoundResult.even;
        Machine crrPlayer = Players.Last();
        Machine crrOpponent = Opponents.First();

        while (result == RoundResult.even)
        {
            result = crrPlayer.Fight(crrOpponent);

            if (result == RoundResult.win)
            {
                Opponents.Remove(crrOpponent);
                return new SingleFightResult(crrPlayer, crrOpponent, crrPlayer);
            }

            if (result == RoundResult.loss)
            {
                Players.Remove(crrPlayer);
                return new SingleFightResult(crrPlayer, crrOpponent, crrOpponent);
            }
        }

        return null;
    }
}