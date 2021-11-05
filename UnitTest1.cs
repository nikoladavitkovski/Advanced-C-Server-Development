using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PassingTest()
        {
            Assert.AreEqual(1,1);
        }

        [TestMethod]

        public void FallingTest()
        {
            Assert.AreEqual(1,2);
        }

        [TestMethod]

        public void CircleVolumeTest()
        {
            Assert.AreEqual("radius","pi");
        }
    }
}
