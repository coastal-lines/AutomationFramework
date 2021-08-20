using AutomationProjectQA.FrameworkCore.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace AutomationProjectQA.Wrapers
{
    public class ElementList : Element
    {
        public List<Element> _listElement;
        private IWebDriver _driver;
        private By _by;

        public ElementList(By by)
        {
            _by = by;
            _driver = DriverClass.GetDriver();
            InstantiateElements();
        }

        public By GetByFromListElements()
        {
            return _by;
        }

        private void InstantiateElements()
        {
            _listElement = new List<Element>();

            var r = _driver.FindElements(_by);

            foreach (var element in _driver.FindElements(_by))
            {
                var _element = new Element(_by);
                _listElement.Add(_element);
            }
        }
    }
}
