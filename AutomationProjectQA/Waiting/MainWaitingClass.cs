using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationProjectQA.WaitingClasses
{
    public class MainWaitingClass
    {
        private int waitingTime = 30;

        public void WaitElement(IWebDriver driver, By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitingTime));
            wait.Until(ExpectedConditions.ElementExists(by));
        }
    }
}