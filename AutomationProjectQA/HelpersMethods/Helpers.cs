using AutomationProjectQA.FrameworkCore.Driver;
using AutomationProjectQA.WaitingClasses;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProjectQA.HelpersMethods
{
    public class Helpers : MainWaitingClass
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
