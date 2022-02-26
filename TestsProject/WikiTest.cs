using AutomationProjectQA.DriverCore.Driver;
using AutomationProjectQA.FrameworkCore.Driver;
using AutomationProjectQA.Wrapers;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace TestsProject
{
    public class WikiTest : BaseTestsClass
    {
        [Test]
        public void JustTest()
        {
            DriverInitiation.GetChromeDriver().Navigate().GoToUrl("https://www.udemy.com/");
            var searchCourseInput = new Element(By.CssSelector("input[placeholder='Search for anything']"));
            searchCourseInput.SetText("C# course");
            var listCourses = new ElementList(By.CssSelector("//div[contains(@class, 'course-list--container')]//h3[@data-purpose='course-title-url']/a"));
            Assert.IsTrue(listCourses.GetElementList().Where(c => c.GetText() == "Learn C# for Beginners Crash Course") != null, "error message");
        }
    }
}