using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TestsProject
{
    public class TestPage : BaseTestsClass
    {
        private IWebDriver driver;

        public TestPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Navigate()
        {
            driver.Navigate().GoToUrl("https://dzone.com/articles/sample-ui-test-automation-framework-design-with-se");
        }
    }
}
