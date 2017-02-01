using NUnit.Framework;

namespace DotNetDesignPatterns.Strategy
{
    [TestFixture]
    public class BarbarianTests
    {
        [Test]
        public void CanAttackWithSword()
        {
            var barbarian = new Barbarian(new MeleeStrategy());
            Assert.That(barbarian.Attack(), Is.EqualTo("Attacked with sword"));
        }

        [Test]
        public void CanChangeAttack()
        {
            var barbarian = new Barbarian(new MeleeStrategy());
            barbarian.ChangeStrategy(new RangeStrategy());
            Assert.That(barbarian.Attack(), Is.EqualTo("Attacked with bow"));
        }
    }
}