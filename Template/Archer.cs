using System;

namespace DotNetDesignPatterns.Template
{
    public class Archer : Fighter
    {
        protected override void Attack()
        {
            Console.WriteLine("Archer shot an arrow.");
        }

        protected override void Move()
        {
            Console.WriteLine("Archer moved 10 feet.");
        }
    }
}