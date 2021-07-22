using AutomationProjectQA.Wrapers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProjectQA.PageObjects.Simple
{
    public class SimplePage : BasicPage
    {
        private readonly Element _elementPreviewContentHolder = new Element(By.ClassName("preview-content-holder"));

        public SimplePage(IWebDriver driver) : base(driver)
        {
        }
    }
}
