using System;

namespace DotNetDesignPatterns.Adapter
{
    public class Barbarian : IFighter
    {
        public void Attack()
        {
            Console.WriteLine("Barbarian attacks with sword.");
        }

        public void Move()
        {
            Console.WriteLine("Barbarian moves 5 feet.");
        }
    }
}