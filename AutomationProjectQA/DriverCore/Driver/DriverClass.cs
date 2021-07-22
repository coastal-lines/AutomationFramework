using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationProjectQA.FrameworkCore.Driver
{
    public static class DriverClass
    {
        private static IWebDriver driver;

        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                driver = CreateDriver();
            }

            return driver;
        }

        private static IWebDriver CreateDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
            }

            return driver;
        }
    }
}
