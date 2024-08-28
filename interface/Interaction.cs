using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using superautomachines.commands;
using superautomachines.commands.data;
using superautomachines.game;

public class Interaction
{
    Regex regex = new Regex(@"\D");
    public ICommand command;
    public void MenuResponse()
    {
        var option = GetInput();
        switch(option)
        {
            case 1:
                command = (ICommand) new NewMatch();
                command.Execute(CommandArgs.args);
                PickPlayers();

                break;
        }
    }

    public int GetInput()
    {
        var input = Console.ReadLine();
        if(regex.IsMatch(input) || input == null)
            return 0;

        return int.Parse(input);
    }

    public void PickPlayers()
    {
        command = (ICommand) new BuyTeamPlayer();
        Console.WriteLine("Pick three players from the market to fight the opponent team.");

        while(true)
        {
            Panels.ShowMarket();
            Panels.ShowPlayersTeam();

            var input = GetInput();
            CommandResponse result = command.Execute(new BuyTeamPlayerArgs(Market.Current.Machines[input]));

            if(!result.Success)
                Console.WriteLine("You cannot buy any other team player.");

            Console.WriteLine("Do you wish to start the round? (y, n)");
            var startRound = GetInput();

            if(startRound == 'y')
                PlayRound();
                break;
        }
    }

    public void PlayRound()
    {
        command = new PlayRound();
        var result = command.Execute();

        if(result.Success)
        {
            Round.NewRound();
            Round.Current.BuildOpponentsComp();
            PickPlayers();
        }

        Panels.PYouLost();
        Game.Init();
    }
}