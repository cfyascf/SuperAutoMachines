using superautomachines.game;
using System.Text.RegularExpressions;
using superautomachines.commands;
using superautomachines.commands.data;
using Match = superautomachines.game.Match;

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
        while(true)
        {
            PlayRound();
            if(Match.Current.Life == 0)
            {
                Panels.GameOver();
                Util.Sleep(3);
                break;
            }
        }
    }

    public void PlayRound()
    {
        command = new NewRound();
        command.Execute(CommandArgs.args);

        PickPlayers();

        Panels.IntroduceFight();

        command = new PlayFight();

        while(true)
        {
            FightCommandResponse result = (FightCommandResponse) command.Execute();

            Console.WriteLine(result.Player.Name.ToUpper() + " against " + result.Opponent.Name.ToUpper());
            Console.WriteLine();
            Util.Sleep(1.2);
            Console.WriteLine(result.Winner.Name.ToUpper() + " WON!");
            Util.Sleep(1);

            if(Round.Current.Opponents.Count == 0)
            {
                Match.Current.Trophies++;
                Panels.FinalMessage(true);
                break;
            }

            if(Round.Current.Players.Count == 0)
            {
                Match.Current.Life--;
                Panels.FinalMessage(false);
                break;
            }
        }
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
    public int GetInput()
    {
        var input = Console.ReadLine();
        if (regex.IsMatch(input) || input == null)
            return 0;

        return int.Parse(input);
    }
}