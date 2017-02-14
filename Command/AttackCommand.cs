using System;

namespace DotNetDesignPatterns.Command
{
    public class AttackCommand : ICommand
    {
        private readonly IFighter _fighter;

        public AttackCommand(IFighter fighter)
        {
            _fighter = fighter;
        }

        public void Execute()
        {
            Console.WriteLine($"{_fighter.Name} attacked with sword.");
        }

        public void Undo()
        {
            Console.WriteLine("Can't undo an attack!");
        }
    }
}