using HtmlAgilityPack;

namespace AutomationProjectQA.HelpersMethods
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

        public string GetTextBySelector(string)
        {

        }
    }
}
