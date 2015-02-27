using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Crocodev.Common.Tests
{
    [TestClass]
    public class Test_Package
    {
        [TestMethod]
        public void Version()
        {
            Assert.AreEqual("1.0.0.4", Crocodev.Version);
        }
    }
}
