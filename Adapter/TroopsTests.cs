using System.Collections.Generic;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace DotNetDesignPatterns.Adapter
{
    [TestFixture]
    public class TroopsTests
    {
        [Test]
        public void AdapterExample()
        {
            var fighters = new List<IFighter>
            {
                new Barbarian(),
                new BarbarianFarmerAdapter(new Farmer())
            };

            var troops = new Troops(fighters);

            troops.StartWar();
        }
    }
}