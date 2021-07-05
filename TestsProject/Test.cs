using NUnit.Framework;

namespace TestsProject
{
    [TestFixture]
    public class Test : BaseTestsClass
    {
        [Test]
        public void TestCase()
        {
            TestPage tp = new TestPage(GetDriver());
            tp.Navigate();
            Assert.AreEqual("Sample UI Test Automation Framework Design with Selenium Grid and Docker - DZone Performance", GetDriver().Title);
        }
    }
}
