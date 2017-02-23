using System;

namespace DotNetDesignPatterns.Composite
{
    public class MoveCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Moved towards nearest enemy.");
        }
    }
}