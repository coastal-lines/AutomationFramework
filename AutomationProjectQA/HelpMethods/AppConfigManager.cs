using System.Configuration;

namespace AutomationProjectQA.HelpMethods
{
    public class AppConfigManager
    {
        public string GetDefaultBrowser()
        {
            return ConfigurationManager.AppSettings["defaultBrowser"].ToString();
        }

        public string GetApiUserName()
        {
            return ConfigurationManager.AppSettings["apiLogin"].ToString();
        }

        public string GetApiUserPassword()
        {
            return ConfigurationManager.AppSettings["apiPassword"].ToString();
        }
    }
}