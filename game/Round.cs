using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

namespace superautomachines.game;


public class Round
{
    public List<Machine> opponents;
    public List<Machine> players;
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

    public RoundResult Play()
    {
        BuildComp();
        return FightComp();
    }

    public void BuildComp()
    {
        
    }

    public RoundResult FightComp()
    {

    }
}