using NUnit.Framework;

namespace DotNetDesignPatterns.Command
{
    [TestFixture]
    public class CommandTests
    {
        [Test]
        public void MoveBarbarian()
        {
            var donny = new Barbarian("Donny");
            var mark = new Barbarian("Mark");
            var game = new Game();

            game.AddCommand(new MoveCommand(donny, 5, 2));
            game.AddCommand(new MoveCommand(mark, 10,3));
            game.AddCommand(new AttackCommand(donny));
            game.AddCommand(new AttackCommand(mark));
            game.AddCommand(new MoveCommand(donny, 4, 2));
            game.AddCommand(new MoveCommand(mark, 5,2));
            game.AddCommand(new AttackCommand(donny));
            game.AddCommand(new AttackCommand(mark));

            game.StartWar();
            game.Rewind();
        }
    }
}