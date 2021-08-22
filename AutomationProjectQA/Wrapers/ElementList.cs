using AutomationProjectQA.FrameworkCore.Driver;
using OpenQA.Selenium;
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
        }

        public By GetByFromListElements()
        {
            return _by;
        }

        public List<Element> GetElementList()
        {
            InstantiateElements();
            return _listElement;
        }

        private void InstantiateElements()
        {
            _listElement = new List<Element>();

            foreach (var element in _driver.FindElements(_by))
            {
                var _element = new Element(_by);
                _listElement.Add(_element);
            }
        }
    }
}
