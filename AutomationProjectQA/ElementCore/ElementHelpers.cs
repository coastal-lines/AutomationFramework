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
            var iframe = DriverClass.GetDriver().FindElement(By.XPath("//iframe[1]"));
            DriverClass.GetDriver().SwitchTo().Frame(0);
        }

        public void SwitchToIFrame(string iframeXPath)
        {
            var iframeElement = DriverClass.GetDriver().FindElement(By.XPath("//" + iframeXPath));
            DriverClass.GetDriver().SwitchTo().Frame(iframeElement);
        }

        #endregion
    }
}
