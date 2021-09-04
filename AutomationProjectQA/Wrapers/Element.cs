using AutomationProjectQA.FrameworkCore.Driver;
using OpenQA.Selenium;
using AutomationProjectQA.HelpMethods;
using System;

namespace AutomationProjectQA.Wrapers
{
    public class Element : ElementHelpers
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

        public Element Wait(WaitMethods condition)
        {
            switch (Int32.Parse(condition.ToString()))
            {
                case 0:
                    WaitElement(this._by);
                    break;
                case 1:
                    WaitElementDisplayed(this._by);
                    break;
                case 2:
                    WaitElementDisappear(this._by);
                    break;
            }

            return this;
        }

        public void Click()
        {
            _element.Click();
        }

        public void WaitElemntAndClick()
        {
            WaitElement(_by);
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
