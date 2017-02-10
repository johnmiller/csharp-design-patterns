using System;

namespace DotNetDesignPatterns.Template
{
    public class Barbarian : Fighter
    {
        protected override void Attack()
        {
            Console.WriteLine("Barbarian attacked with sword.");
        }
    }
}