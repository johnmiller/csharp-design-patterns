using System;

namespace DotNetDesignPatterns.Composite
{
    public class AttackCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Attacked with sword.");
        }
    }
}