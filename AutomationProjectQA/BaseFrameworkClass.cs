using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationProjectQA
{
    public class BaseFrameworkClass
    {
        private static IWebDriver driver;

        public static IWebDriver CreateDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
            }

            return driver;
        }
    }
}
