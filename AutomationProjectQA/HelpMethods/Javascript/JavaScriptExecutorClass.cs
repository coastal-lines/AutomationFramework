using AutomationProjectQA.FrameworkCore.Driver;
using OpenQA.Selenium;

namespace AutomationProjectQA.HelpMethods
{
    public class JavaScriptExecutorClass
    {
        public void RunJavaScript(string script)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor) DriverClass.GetDriver();
            var result = (string) js.ExecuteScript(script);
        }

        public string RunJavaScriptAndGetResult(string script)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)DriverClass.GetDriver();
            var result = (string)js.ExecuteScript(script);

            return result;
        }
    }
}
