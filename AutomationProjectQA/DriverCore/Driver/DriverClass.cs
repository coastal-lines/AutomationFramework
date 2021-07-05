using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationProjectQA.FrameworkCore.Driver
{
    public class DriverClass : BaseFrameworkClass
    {
        private IWebDriver driver;


        public IWebDriver GetDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
            }

            return driver;
        }
    }
}
