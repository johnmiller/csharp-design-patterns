namespace DotNetDesignPatterns.Strategy
{
    public class MeleeStrategy : IFightingStrategy
    {
        public string ExecuteAction()
        {
            return "Attacked with sword";
        }
    }
}