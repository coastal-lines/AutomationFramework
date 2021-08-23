using AutomationProjectQA.FrameworkCore.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Drawing;

namespace AutomationProjectQA.HelpersMethods
{
    public class ElementActions : JavaScriptExecutorClass
    {
        public void ClickBySelenium(IWebElement element)
        {
            element.Click();
        }

        public void RightClickBySelenium(IWebElement element)
        {
            new Actions(DriverClass.GetDriver()).ContextClick(element).Build().Perform();
        }

        public void DoubleClickBySelenium(IWebElement element)
        {
            new Actions(DriverClass.GetDriver()).DoubleClick(element).Build().Perform();
        }

        public void DragAndDropBySelenium(IWebElement elementSource, IWebElement elementTarget)
        {
            new Actions(DriverClass.GetDriver()).DragAndDrop(elementSource, elementTarget).Build().Perform();
        }

        public void DragAndDropByCoordinatesBySelenium(IWebElement elementSource, int x, int y)
        {
            new Actions(DriverClass.GetDriver()).DragAndDropToOffset(elementSource, x, y).Build().Perform();
        }

        public void ScrollBySelenium(int x, int y)
        {
            string script = $"window.scroll({x}, {y});";
            RunJavaScript(script);
        }

        public void MoveCursorOnElementBySelenium(IWebElement element)
        {
            new Actions(DriverClass.GetDriver()).MoveToElement(element).Build().Perform();
        }

        public Point GetElementCoordinatesBySelenium(IWebElement element)
        {
            return element.Location;
        }


    }
}
