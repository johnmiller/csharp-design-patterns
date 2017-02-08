using System;

namespace DotNetDesignPatterns.Adapter
{
    public class BarbarianFarmerAdapter : IFighter
    {
        private readonly Farmer _farmer;

        public BarbarianFarmerAdapter(Farmer farmer)
        {
            _farmer = farmer;
        }

        public void Attack()
        {
            Console.WriteLine("Farmer attacks with sword.");
        }

        public void Move()
        {
            _farmer.Move();
        }
    }
}