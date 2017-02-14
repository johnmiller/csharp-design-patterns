namespace DotNetDesignPatterns.Command
{
    public class MoveCommand : ICommand
    {
        private readonly IFighter _fighter;
        private readonly int _stepsX;
        private readonly int _stepsY;


        public MoveCommand(IFighter fighter, int stepsX, int stepsY)
        {
            _fighter = fighter;
            _stepsX = stepsX;
            _stepsY = stepsY;
        }

        public void Execute()
        {
            _fighter.Move(_stepsX, _stepsY);
        }

        public void Undo()
        {
            _fighter.Move(_stepsX * -1, _stepsY * -1);
        }
    }
}