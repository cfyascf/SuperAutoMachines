namespace superautomachines.game;
public class Match
{
    public int Life { get; set; } = 5;
    public int Trophies { get; set; } = 0;
    public Round crrRound = null;
    public static Match crr = null;
    public static Match Current 
    {
        get
        {
            if(crr == null)
            {
                crr = new Match();
            }

            return crr;
        }
    }

    public static Match NewMatch()
    {
        crr = new Match();
        return Current;
    }

    public void Start()
    {
        crrRound = Round.NewRound();
        crrRound.BuildOpponentsComp();
    }

    public void Play()
    {
        RoundResult result;
        while(Life > 0)
        {
            result = crrRound.FightComp();
            if(result == RoundResult.win)
                Trophies++;
            else
                Life--;
        }
    }
}