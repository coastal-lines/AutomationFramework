using AutomationProjectQA.FrameworkCore.Driver;
using AutomationProjectQA.Waiting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace AutomationProjectQA.WaitingClasses
{
    public class MainWaitingClass : WaitMethodsList
    {
        private int waitingTime = 30;
        private IWebDriver driver;

        public MainWaitingClass()
        {
            this.driver = StaticDriverClass.GetSeleniumChromeDriver();
        }

        public void WaitElement(By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitingTime));
            wait.Until(ExpectedConditions.ElementExists(by));
        }

        public void WaitElementDisplayed(By by)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitingTime));
                wait.Until(ExpectedConditions.ElementIsVisible(by));
            }
            catch (NoSuchElementException err)
            {
                Console.WriteLine("Element with locator '" + by + "' is not displayed");
            }
        }

        public void WaitElementDisappear(By by, int waitingTime = 30)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitingTime));
                wait.Until(ExpectedConditions.InvisibilityOfElementLocated(by));
            }
            catch (NoSuchElementException err)
            {
                Console.WriteLine("Element with locator '" + by + "' is displayed");
            }
        }
    }
}