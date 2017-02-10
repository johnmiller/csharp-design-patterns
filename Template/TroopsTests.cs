using System.Collections.Generic;
using NUnit.Framework;

namespace DotNetDesignPatterns.Template
{
    [TestFixture]
    public class TroopsTests
    {
        [Test]
        public void TemplatePatternExample()
        {
            var fighters = new List<Fighter>
            {
                new Archer(),
                new Barbarian(),
                new Giant(),
                new Barbarian(),
                new Archer()
            };

            var troops = new Troops(fighters);

            troops.StartWar();
        }
    }
}