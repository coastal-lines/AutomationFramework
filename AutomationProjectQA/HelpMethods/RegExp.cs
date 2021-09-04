using System.Text.RegularExpressions;

namespace AutomationProjectQA.HelpMethods
{
    public class RegExp
    {
        public string MakeRegExp(string text, string pattern, int group = 0)
        {
            Regex rx = new Regex(pattern);
            MatchCollection matches = rx.Matches(text);

            return matches[group].Value;
        }
    }
}
