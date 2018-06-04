using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Game15.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var game = new WindowsFormsApp1.Game15(3);
            game.start();
            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(i + 1, game.get_number(i));
            }
            Assert.AreEqual(0, game.get_number(8));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var game = new WindowsFormsApp1.Game15(4);
            game.shift(14);
            game.check_numbers();
            Assert.AreEqual(false, game.check_numbers());
        }
    }
}
