using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProjectQA.HelpersMethods
{
    public class HtmlParser
    {
        public string ReadHtmlFromText(string html)
        {
            var doc = new HtmlDocument();
            doc.LoadHtml(html);
        }

        public string ReadHtmlFromFile(string filePath)
        {
            var doc = new HtmlDocument();
            doc.Load(filePath);
        }
    }
}
