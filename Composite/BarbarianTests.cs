using NUnit.Framework;

namespace DotNetDesignPatterns.Composite
{
    [TestFixture]
    public class BarbarianTests
    {
        [Test]
        public void CompositeTest()
        {
            var barbarian = new Barbarian();
            barbarian.GiveCommand(new MoveCommand());
            barbarian.GiveCommand(new AttackCommand());

            var surgeCommand = new SurgeAttackCommand();
            surgeCommand.AddCommand(new MoveCommand());
            surgeCommand.AddCommand(new AttackCommand());
            surgeCommand.AddCommand(new AttackCommand());
            barbarian.GiveCommand(surgeCommand);

            barbarian.GiveCommand(new MoveCommand());

            barbarian.PerformCommands();
        }
    }
}