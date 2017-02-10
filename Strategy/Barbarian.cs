namespace DotNetDesignPatterns.Strategy
{
    public class Barbarian
    {
        private IFightingStrategy _strategy;

        public Barbarian(IFightingStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ChangeStrategy(IFightingStrategy strategy)
        {
            _strategy = strategy;
        }

        public string Attack()
        {
            return _strategy.ExecuteAction();
        }
    }
}