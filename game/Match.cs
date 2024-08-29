namespace superautomachines.game;
public class Match
{
    public int Life { get; set; } = 5;
    public int Trophies { get; set; } = 0;
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

    public static void NewMatch()
    {
        crr = new Match();
    }
}