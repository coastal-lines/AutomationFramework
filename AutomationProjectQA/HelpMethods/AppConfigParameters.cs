using System.Configuration;

namespace AutomationProjectQA.HelpMethods
{
    public static class AppConfigParameters
    {
        public static string GetDefaultBrowser()
        {
            return ConfigurationManager.AppSettings["defaultBrowser"].ToString();
        }
    }
}