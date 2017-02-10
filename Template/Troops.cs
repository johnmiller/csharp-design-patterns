using System.Collections.Generic;

namespace DotNetDesignPatterns.Template
{
    public class Troops
    {
        private IEnumerable<Fighter> _fighters;

        public Troops(IEnumerable<Fighter> fighters)
        {
            _fighters = fighters;
        }

        public void StartWar()
        {
            foreach (var fighter in _fighters)
                fighter.Execute();
        }
    }
}