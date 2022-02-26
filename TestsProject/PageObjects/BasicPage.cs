using OpenQA.Selenium;

namespace AutomationProjectQA.PageObjects.Simple
{
    public class BasicPage
    {
        private IWebDriver driver;

        public BasicPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
