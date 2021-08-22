using AutomationProjectQA.FrameworkCore.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using AutomationProjectQA.HelpersMethods;

namespace AutomationProjectQA.Wrapers
{
    public class Element : Helpers
    {
        private IWebElement _element;
        private IWebDriver _driver;
        private By _by;

        private const int DefaultWaitTimeoutSeconds = 60;

        public Element()
        {

        }

        public Element(By by)
        {
            _by = by;
            _driver = DriverClass.GetDriver();
        }

        public By GetByElement()
        {
            return _by;
        }

        public Element InstantiateElement()
        {
            _element = _driver.FindElement(_by);
            return this;
        }

        public void Click()
        {
            _element.Click();
        }

        public void WaitElemntAndClick()
        {
            WaitElement(_driver, _by);
            _element.Click();
        }

        public string GetText()
        {
            return _element.Text;
        }

        public void SetText(string text)
        {
            _element.SendKeys(text);
        }
    }
}
