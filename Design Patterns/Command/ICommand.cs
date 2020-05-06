namespace Takerman.DesignPatterns.CommandPattern
{
    public interface ICommand
    {
        void execute();
        void unexecute();
    }
}
