using AutomationProjectQA.Wrapers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProjectQA.PageObjects.Simple
{
    public class WikiPage : BasicPage
    {
        private readonly Element logo = new Element(By.CssSelector("img[alt='Chromium Embedded Framework Logo.png']"));
        private readonly Element seeAlsoList = new Element(By.XPath("//div[@aria-label='Portals']/following-sibling::*[1]/li"));

        public WikiPage(IWebDriver driver) : base(driver)
        {
        }


    }
}
