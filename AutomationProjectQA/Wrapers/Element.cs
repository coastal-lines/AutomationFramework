using AutomationProjectQA.FrameworkCore.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationProjectQA.Wrapers
{
    public class Element
    {
        private IWebElement _element;
        private IWebDriver _driver;
        private By _by;
        private WebDriverWait _wait;

        private const int DefaultWaitTimeoutSeconds = 60;

        public Element()
        {

        }

        public Element(By by)
        {
            _by = by;
            _driver = DriverClass.GetDriver();
            _wait = new WebDriverWait(DriverClass.GetDriver(), TimeSpan.FromSeconds(DefaultWaitTimeoutSeconds));
        }

        private void InstantiateElement()
        {
            _element = _driver.FindElement(_by);
        }

        public void Click()
        {
            InstantiateElement();
            _element.Click();
        }
    }
}
