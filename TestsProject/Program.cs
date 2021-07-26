using AutomationProjectQA.Wrapers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Chromium_Embedded_Framework");
            var logo = new Element(By.CssSelector("img[alt='Chromium Embedded Framework Logo.png']"));
            //logo.Click();
            var listProducts = new ElementList(By.XPath("//div[@class='mw-parser-output']/ul[1]/li"));


            driver.Close();
            driver.Dispose();
        }
    }
}
