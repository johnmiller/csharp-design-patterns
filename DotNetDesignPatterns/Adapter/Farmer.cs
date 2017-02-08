using System;

namespace DotNetDesignPatterns.Adapter
{
    public class Farmer
    {
        public void Move()
        {
            Console.WriteLine("Farmer moves 5 feet.");
        }

        public void FeedAnimals()
        {
            Console.WriteLine("Farmer feeds his animals.");
        }
    }
}