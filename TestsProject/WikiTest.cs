using AutomationProjectQA.Wrapers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsProject
{
    public class WikiTest : BaseTestsClass
    {
        [Test]
        public void JustTest()
        {
            GetDriver().Navigate().GoToUrl("https://en.wikipedia.org/wiki/Chromium_Embedded_Framework");
            var logo = new Element(By.CssSelector("img[alt='Chromium Embedded Framework Logo.png']"));
            var listProducts = new ElementList(By.XPath("//div[@class='mw-parser-output']/ul[1]/li"));
            foreach (var item in listProducts._listElement)
            {
                Console.WriteLine(item.GetText());
            }
        }
    }
}
