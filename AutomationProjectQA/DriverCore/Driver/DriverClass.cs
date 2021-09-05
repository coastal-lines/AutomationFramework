using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationProjectQA.FrameworkCore.Driver
{
    public static class DriverClass
    {
        private static IWebDriver seleniumChromeDriver;

        public static IWebDriver GetSeleniumChromeDriver()
        {
            if (seleniumChromeDriver == null)
            {
                seleniumChromeDriver = CreateSeleniumChromeDriver();
            }

            return seleniumChromeDriver;
        }

        public static IWebDriver CreateSeleniumChromeDriver()
        {
            if (seleniumChromeDriver == null)
            {
                seleniumChromeDriver = new ChromeDriver();
            }

            return seleniumChromeDriver;
        }
    }
}
