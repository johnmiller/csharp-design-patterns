using System;

namespace DotNetDesignPatterns.Template
{
    public abstract class Fighter
    {
        protected virtual void Move()
        {
            Console.WriteLine($"{GetType().Name} moved 5 feet.");
        }

        protected abstract void Attack();

        public void Execute()
        {
            Move();
            Attack();
        }
    }
}