using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using superautomachines.commands;
using superautomachines.commands.data;
using superautomachines.game;

public class Interaction
{
    Regex regex = new Regex(@"\D");
    public ICommand command;
    public void Menu()
    {
        Panels.Menu();
        var option = GetInput();
        switch (option)
        {
            case 1:
                StartMatch();
                Play();
                break;
        }
    }

    public void StartMatch()
    {
        command = new NewMatch();
        command.Execute(CommandArgs.args);
    }

    public void Play()
    {
        command = new NewRound();
        command.Execute(CommandArgs.args);

        PickPlayers();
        PlayRound();
    }

    public void PickPlayers()
    {
        command = new BuyTeamPlayer();
        Console.WriteLine("Pick three players from the market to fight the opponent team.");
        Util.Sleep(1);

        while (true)
        {
            Panels.ShowMarket();
            Panels.ShowPlayersTeam();

            if (Market.Current.Machines.Count == 0)
            {
                Console.WriteLine("There's no more machines to buy...");
                Console.WriteLine("The round is going to be started.");
                Util.Sleep(1);

                return;
            }

            var input = GetInput();

            if (input > Market.Current.Machines.Count ||
                input < 1)
            {
                Console.WriteLine("There's no such option.");
                continue;
            }

            CommandResponse result = command.Execute(new BuyTeamPlayerArgs(Market.Current.Machines[input - 1]));

            if (!result.Success)
                Console.WriteLine("You cannot buy any other team player.");

            Console.WriteLine("Do you wish to start the round? (1 for y, 0 for n)");
            var startRound = GetInput();

            if (startRound == 1)
                break;
        }
    }

    public void PlayRound()
    {
        Panels.ShowOpponentsTeam();
        Util.Sleep(1.1);
        Panels.VS();
        Util.Sleep(1.1);
        Panels.ShowPlayersTeam();
        Util.Sleep(1.1);

        command = new PlayRound();
        RoundCommandResponse result = (RoundCommandResponse) command.Execute();

        if (result.RoundResult == RoundResult.win)
        {
            Play();
        }

        Panels.PYouLost();
        Game.Init();
    }
    
    public void PlayX1()
    {
        
    }

    public int GetInput()
    {
        var input = Console.ReadLine();
        if (regex.IsMatch(input) || input == null)
            return 0;

        return int.Parse(input);
    }
}