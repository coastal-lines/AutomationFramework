using System.Configuration;

namespace AutomationProjectQA.HelpersMethods
{
    public static class AppConfigParameters
    {
        public static string GetDefaultBrowser()
        {
            return ConfigurationManager.AppSettings["defaultBrowser"].ToString();
        }
    }
}