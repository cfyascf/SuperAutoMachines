using superautomachines.game;
using superautomachines.machines;

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

    public static void YourYeam()
    {
        Console.WriteLine(@"
            __   __                 _____                    
            \ \ / /__  _   _ _ __  |_   _|__  __ _ _ __ ___  
             \ V / _ \| | | | '__|   | |/ _ \/ _` | '_ ` _ \ 
              | | (_) | |_| | |      | |  __/ (_| | | | | | |
              |_|\___/ \__,_|_|      |_|\___|\__,_|_| |_| |_|
        ");
    }

    public static void Opponents()
    {
        Console.WriteLine(@"
              ___                                     _       
             / _ \ _ __  _ __   ___  _ __   ___ _ __ | |_ ___ 
            | | | | '_ \| '_ \ / _ \| '_ \ / _ \ '_ \| __/ __|
            | |_| | |_) | |_) | (_) | | | |  __/ | | | |_\__ \
             \___/| .__/| .__/ \___/|_| |_|\___|_| |_|\__|___/
                  |_|   |_|                                   
        ");
    }

    public static void VS()
    {
        Console.WriteLine(@"
            __     ______  
            \ \   / / ___| 
             \ \ / /\___ \ 
              \ V /  ___) |
               \_/  |____/     
        ");
    }

    public static void YouWon()
    {
        Console.WriteLine(@"
             __   __           __        __          _ 
             \ \ / /__  _   _  \ \      / /__  _ __ | |
              \ V / _ \| | | |  \ \ /\ / / _ \| '_ \| |
               | | (_) | |_| |   \ V  V / (_) | | | |_|
               |_|\___/ \__,_|    \_/\_/ \___/|_| |_(_)
        ");
    }

    public static void GameOver()
    {
        Console.WriteLine(@"
             ██████╗  █████╗ ███╗   ███╗███████╗     ██████╗ ██╗   ██╗███████╗██████╗ 
             ██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔═══██╗██║   ██║██╔════╝██╔══██╗
             ██║  ███╗███████║██╔████╔██║█████╗      ██║   ██║██║   ██║█████╗  ██████╔╝
             ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██║   ██║╚██╗ ██╔╝██╔══╝  ██╔══██╗
             ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ╚██████╔╝ ╚████╔╝ ███████╗██║  ██║
              ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝     ╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═╝
        ");
    }

    public static void ShowMarket()
    {
        PMarket();
        Console.WriteLine("* Your coins: " + Round.Current.Coins);
        if (Market.Current.Machines.Count == 0)
        {
            Console.WriteLine("...empty...");
        }

        var l = 0;
        foreach (var machine in Market.Current.Machines)
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
        YourYeam();
        if (Round.Current.Players.Count == 0)
        {
            Console.WriteLine("...empty...");
        }

        foreach (var machine in Round.Current.Players)
        {
            ShowMachine(machine);
        }
        Console.WriteLine();
    }

    public static void ShowOpponentsTeam()
    {
        Opponents();
        foreach (var machine in Round.Current.Opponents)
        {
            ShowMachine(machine);
            Console.WriteLine();
        }
    }

    public static void ShowMachine(Machine machine)
    {
        Console.WriteLine(machine.Name.ToUpper());
        Console.Write("Attack: " + machine.Attack);
        Console.Write(" - Life: " + machine.Life);
        Console.Write(" - Tier: " + machine.Tier);
        Console.WriteLine();
    }

    public static void IntroduceFight()
    {
        ShowOpponentsTeam();
        Util.Sleep(1.5);
        VS();
        Util.Sleep(1.1);
        ShowPlayersTeam();
        Util.Sleep(1.5);
    }

    public static void FinalMessage(bool result)
    {
        if(result)
            YouWon();
        else
            PYouLost();

        Util.Sleep(1);
        Console.WriteLine("You " + (result? "won":"lost") + " this round!");
        Util.Sleep(0.5);
        Console.WriteLine("Trophies conquered: " + Match.Current.Trophies);
        Util.Sleep(0.5);
        Console.WriteLine("Life remaining: " + Match.Current.Life);
        Util.Sleep(0.5);
        Console.WriteLine("Another round is goind to start...");
        Util.Sleep(1);
    }
}