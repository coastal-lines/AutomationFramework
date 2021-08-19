using AutomationProjectQA.FrameworkCore.Driver;
using AutomationProjectQA.HelpersMethods;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TestsProject
{
    public class BaseTestsClass : Helpers
    {
        private IWebDriver driver;

        public IWebDriver GetDriver()
        {
            if (driver == null)
            {
                InitDriver();
            }

            return driver;
        }

        [SetUp]
        public void InitDriver()
        {
            driver = DriverClass.CreateDriver();
        }

        [TearDown]
        public void CleanDriver()
        {
            if (driver != null)
            {
                driver.Close();
                driver.Dispose();
            }
        }
    }
}