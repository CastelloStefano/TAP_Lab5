using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace Lab5.Test
{
    [TestFixture]
    class Test
    {
        [Test]
        public void Atmp()
        {
            IEnumerable<int> enumi = new List<int>(1);
            int due = 2;
            Assert.That(Macro.Macro.MacroExpansion<int>(enumi,due,enumi).GetType(),Is.EqualTo(1.GetType()));
        }

    }
}
