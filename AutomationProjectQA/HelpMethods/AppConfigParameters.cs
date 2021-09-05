using System.Configuration;

namespace AutomationProjectQA.HelpMethods
{
    public class AppConfigParameters
    {
        public string GetDefaultBrowser()
        {
            return ConfigurationManager.AppSettings["defaultBrowser"].ToString();
        }
    }
}