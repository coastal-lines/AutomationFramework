using AutomationProjectQA.DriverCore.Driver;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationProjectQA.FrameworkCore.Driver
{
    public static class StaticDriverClass
    {
        private static IWebDriver seleniumChromeDriver;

        public static IWebDriver GetSeleniumChromeDriver()
        {
            if (seleniumChromeDriver == null)
            {
                seleniumChromeDriver = DriverInitiation.GetChromeDriver();
            }

            return seleniumChromeDriver;
        }
    }
}