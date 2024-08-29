namespace superautomachines.commands;
using superautomachines.commands.data;

public interface ICommand
{
    public CommandResponse Execute(CommandArgs args = default);
}