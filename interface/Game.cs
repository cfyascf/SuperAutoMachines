public class Game
{
    public static Interaction i { get; set; } = new Interaction();

    public static void Init()
    {
        Panels.PTitle();
        Util.Sleep(1.2);
        
        i.Menu();
    }
}