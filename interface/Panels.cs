using superautomachines.game;

public static class Panels
{
    public static void PTitle()
    {
        Console.WriteLine(@"
              _____ __ __  ____   ___  ____        ____  __ __  ______   ___       ___ ___   ____    __  __ __  ____  ____     ___  _____
             / ___/|  |  ||    \ /  _]|    \      /    ||  |  ||      | /   \     |   |   | /    |  /  ]|  |  ||    ||    \   /  _]/ ___/
            (   \_ |  |  ||  o  )  [_ |  D  )    |  o  ||  |  ||      ||     |    | _   _ ||  o  | /  / |  |  | |  | |  _  | /  [_(   \_ 
             \__  ||  |  ||   _/    _]|    /     |     ||  |  ||_|  |_||  O  |    |  \_/  ||     |/  /  |  _  | |  | |  |  ||    _]\__  |
             /  \ ||  :  ||  | |   [_ |    \     |  _  ||  :  |  |  |  |     |    |   |   ||  _  /   \_ |  |  | |  | |  |  ||   [_ /  \ |
             \    ||     ||  | |     ||  .  \    |  |  ||     |  |  |  |     |    |   |   ||  |  \     ||  |  | |  | |  |  ||     |\    |
              \___| \__,_||__| |_____||__|\_|    |__|__| \__,_|  |__|   \___/     |___|___||__|__|\____||__|__||____||__|__||_____| \___|
            ");
    }

    public static void Menu()
    {
        Console.WriteLine(@"
            ----------------------------------
            |        CHOOSE YOUR OPTION      |
            ----------------------------------
            |         1. Start match         |
            |                                |
            ----------------------------------
        ");
    }

    public static void PMarket()
    {
        Console.WriteLine(@"            
             __  __            _        _   
            |  \/  |          | |      | |  
            | \  / | __ _ _ __| | _____| |_ 
            | |\/| |/ _` | '__| |/ / _ \ __|
            | |  | | (_| | |  |   <  __/ |_ 
            |_|  |_|\__,_|_|  |_|\_\___|\__|
        ");
    }

    public static void PTeams()
    {
        Console.WriteLine(@"
              _______                       
             |__   __|                      
                | | ___  __ _ _ __ ___  ___ 
                | |/ _ \/ _` | '_ ` _ \/ __|
                | |  __/ (_| | | | | | \__ \
                |_|\___|\__,_|_| |_| |_|___/
        ");
    }

    public static void PYouLost()
    {
        Console.WriteLine(@"      
             __     __           _           _   _ 
             \ \   / /          | |         | | | |
              \ \_/ /__  _   _  | | ___  ___| |_| |
               \   / _ \| | | | | |/ _ \/ __| __| |
                | | (_) | |_| | | | (_) \__ \ |_|_|
                |_|\___/ \__,_| |_|\___/|___/\__(_)
        ");
    }

    public static void ShowMarket()
    {
        PMarket();
        Console.WriteLine("* Your coins: " + Round.Current.Coins);
        var l = 0;  
        foreach(var machine in Market.Current.Machines)
        {
            l++;
            Console.WriteLine(l + ". " + machine.Name.ToUpper());
            Console.WriteLine("Attack: " + machine.Attack);
            Console.WriteLine("Life: " + machine.Life);
            Console.WriteLine("Price: " + machine.Price);
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public static void ShowPlayersTeam()
    {
        Console.WriteLine("_YOUR TEAM_");
        foreach(var machine in Round.Current.Players)
        {
            Console.WriteLine(machine.Name.ToUpper());
            Console.WriteLine("Attack: " + machine.Attack + "Life: " + machine.Life);
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}