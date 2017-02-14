namespace DotNetDesignPatterns.Command
{
    public interface IFighter
    {
        string Name { get; }
        int PositionX { get; }
        int PositionY { get; }
        void Move(int x, int y);
    }
}