using NUnit.Framework;

namespace Lab5.Test
{
    [TestFixture]
    class Test
    {
        [Test]
        public void Atmp()
        {
            Macro.Macro.MacroExpansion<int>();
        }

    }
}
