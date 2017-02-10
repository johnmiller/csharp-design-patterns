namespace DotNetDesignPatterns.Strategy
{
    public class RangeStrategy : IFightingStrategy
    {
        public string ExecuteAction()
        {
            return "Attacked with bow";
        }
    }
}