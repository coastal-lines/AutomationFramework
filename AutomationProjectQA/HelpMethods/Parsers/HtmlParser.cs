using HtmlAgilityPack;

namespace AutomationProjectQA.HelpMethods
{
    public class HtmlParser
    {
        public HtmlDocument ReadHtmlFromText(string html)
        {
            var doc = new HtmlDocument();
            doc.LoadHtml(html);

            return doc;
        }

        public HtmlDocument ReadHtmlFromFile(string filePath)
        {
            var doc = new HtmlDocument();
            doc.Load(filePath);

            return doc;
        }

        public string GetTextBySelector(HtmlDocument doc, string path)
        {
            var value = doc.DocumentNode
             .SelectNodes("//div")[1]
             .Attributes["id"].Value;

            return value;
        }
    }
}
