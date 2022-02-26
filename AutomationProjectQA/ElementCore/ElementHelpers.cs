using AutomationProjectQA.FrameworkCore.Driver;
using AutomationProjectQA.WaitingClasses;
using OpenQA.Selenium;

namespace AutomationProjectQA.HelpMethods
{
    public class ElementHelpers : MainWaitingClass
    {
        #region For IFrames

        public void SwitchToTheFirstIFrame()
        {
            var iframe = StaticDriverClass.GetSeleniumChromeDriver().FindElement(By.XPath("//iframe[1]"));
            StaticDriverClass.GetSeleniumChromeDriver().SwitchTo().Frame(0);
        }

        public void SwitchToIFrame(string iframeXPath)
        {
            var iframeElement = StaticDriverClass.GetSeleniumChromeDriver().FindElement(By.XPath("//" + iframeXPath));
            StaticDriverClass.GetSeleniumChromeDriver().SwitchTo().Frame(iframeElement);
        }

        #endregion
    }
}
