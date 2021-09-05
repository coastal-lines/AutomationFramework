using AutomationProjectQA.FrameworkCore.Driver;
using AutomationProjectQA.HelpMethods;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TestsProject
{
    public class BaseTestsClass : ElementHelpers
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
            driver = DriverClass.CreateSeleniumChromeDriver();
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