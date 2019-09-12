using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pukmaster.JsonToolbox.Tests
{
    [TestClass]
    public class JsonToolboxTests
    {
        [TestMethod]
        public void Initialize_Default_NoException()
        {
            var jsonToolbox = new JsonToolbox();
        }
    }
}