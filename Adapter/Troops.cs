using System.Collections.Generic;

namespace DotNetDesignPatterns.Adapter
{
    public class Troops
    {
        private readonly IEnumerable<IFighter> _fighters;

        public Troops(IEnumerable<IFighter> fighters)
        {
            _fighters = fighters;
        }

        public void StartWar()
        {
            foreach (var fighter in _fighters)
            {
                fighter.Move();
                fighter.Attack();
            }
        }
    }
}