using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProjectQA.WaitingClasses
{
    public static class MainWaitingClass
    {
        public static void WaitElement(IWebDriver driver, By by)
        {
            WebDriverWait w = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            w.Until(ExpectedConditions.ElementExists(by));
        }
    }
}
