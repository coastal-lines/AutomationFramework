using AutomationProjectQA.FrameworkCore.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace AutomationProjectQA.HelpersMethods
{
    public class ElementActions
    {
        public void ClickBySelenium(IWebElement element)
        {
            element.Click();
        }

        public void DoubleClickBySelenium(IWebElement element)
        {
            new Actions(DriverClass.GetDriver()).DoubleClick(element).Build().Perform();
        }
    }
}
