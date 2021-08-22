using AutomationProjectQA.FrameworkCore.Driver;
using AutomationProjectQA.Waiting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationProjectQA.WaitingClasses
{
    public class MainWaitingClass : WaitMethodsList
    {
        private int waitingTime = 30;
        private IWebDriver driver;

        public MainWaitingClass()
        {
            this.driver = DriverClass.GetDriver();
        }

        public void WaitElement(By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitingTime));
            wait.Until(ExpectedConditions.ElementExists(by));
        }
    }
}