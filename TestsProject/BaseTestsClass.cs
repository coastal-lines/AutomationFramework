using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationProjectQA;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TestsProject
{
    public class BaseTestsClass
    {
        private IWebDriver driver;

        public IWebDriver GetDriver()
        {
            if (driver == null)
            {
                InitDriver();
            }

            return driver;
        }

        public void InitDriver()
        {
            driver = BaseFrameworkClass.CreateDriver();
        }

        [TearDown]
        public void CleanDriver()
        {
            if (driver != null)
            {
                driver.Close();
                driver.Dispose();
            }
        }
    }
}