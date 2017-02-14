namespace DotNetDesignPatterns.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}