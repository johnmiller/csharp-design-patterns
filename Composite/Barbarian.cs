using System.Collections.Generic;

namespace DotNetDesignPatterns.Composite
{
    public class Barbarian
    {
        private List<ICommand> _commands;

        public Barbarian()
        {
            _commands = new List<ICommand>();
        }

        public void GiveCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void PerformCommands()
        {
            _commands.ForEach(x => x.Execute());
        }
    }
}