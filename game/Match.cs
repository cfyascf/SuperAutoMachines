namespace superautomachines.game;
public class Match
{
    public int Coins { get; set; } = 10;
    public int Life { get; set; } = 5;
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
        var result = crrRound.Play();
    }
}