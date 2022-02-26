using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProjectQA.DriverCore.Driver
{
    public static class DriverInitiation
    {
        private static IWebDriver seleniumChromeDriver;

        public static IWebDriver GetChromeDriver()
        {
            if (seleniumChromeDriver == null)
            {
                seleniumChromeDriver = new ChromeDriver();
            }

            return seleniumChromeDriver;
        }

        [SetUp]
        public static void InitDriver()
        {
            seleniumChromeDriver = GetChromeDriver();
        }

        [TearDown]
        public static void CleanDriver()
        {
            if (seleniumChromeDriver != null)
            {
                seleniumChromeDriver.Close();
                seleniumChromeDriver.Dispose();
            }
        }
    }
}
