public class Game
{
    public static async void Init()
    {
        Interaction i = new Interaction();
        Panels.PTitle();
        Util.Sleep(1.2);
        Panels.Menu();
        i.MenuResponse();
    }
}