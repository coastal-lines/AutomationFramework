using AutomationProjectQA.FrameworkCore.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace AutomationProjectQA.Wrapers
{
    public class ElementList
    {
        private IList<Element> _element;
        private IWebDriver _driver;
        private By _by;
        private WebDriverWait _wait;

        private const int DefaultWaitTimeoutSeconds = 60;

        public ElementList(By by)
        {
            _by = by;
            _driver = DriverClass.GetDriver();
            _wait = new WebDriverWait(DriverClass.GetDriver(), TimeSpan.FromSeconds(DefaultWaitTimeoutSeconds));
        }

        private void InstantiateElement()
        {
            _element = _driver.FindElements(_by);
        }
    }
}
