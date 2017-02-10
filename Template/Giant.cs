using System;

namespace DotNetDesignPatterns.Template
{
    public class Giant : Fighter
    {
        protected override void Attack()
        {
            Console.WriteLine("Giant smashed with their fists.");
        }

        protected override void Move()
        {
            Console.WriteLine("Giant moved 3 feet.");
        }
    }
}