using AutomationProjectQA.Wrapers;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TestsProject
{
    public class WikiTest : BaseTestsClass
    {
        [Test]
        public void JustTest()
        {
            GetDriver().Navigate().GoToUrl("https://mail.rambler.ru/");
            var login = new Element(By.Id("login"));
            var password = new Element(By.Id("password"));
            var enter = new Element(By.ClassName("rui-Button-content"));
            SwitchToTheFirstIFrame();
            login.Wait(WaitMethods.Wait).InstantiateElement().Click();
            login.SetText("");
            password.InstantiateElement().Click();
            password.SetText("");
            enter.InstantiateElement().Click();

            var list = new ElementList(By.CssSelector("div[class='MailList-list-2L'] div[draggable='true']"));
            WaitElement(list.GetByFromListElements());
            Assert.IsTrue(list.GetElementList().Count > 10, "");


        }
    }
}
