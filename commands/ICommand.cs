namespace superautomachines.commands;

public interface ICommand<T>
{
    public void Execute(T args = default);
}