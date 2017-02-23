using System;
using System.Collections.Generic;

namespace DotNetDesignPatterns.Composite
{
    public class SurgeAttackCommand : ICommand
    {
        private List<ICommand> _commands;

        public SurgeAttackCommand()
        {
            _commands = new List<ICommand>();
        }

        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void Execute()
        {
            Console.WriteLine("Starting surge attack.");
            _commands.ForEach(x => x.Execute());
            Console.WriteLine("Surge attack finished.");
        }
    }
}