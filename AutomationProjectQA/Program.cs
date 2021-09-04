using AutomationProjectQA.HelpMethods;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProjectQA
{
    class Program
    {
        

        static void Main(string[] args)
        {
            HtmlParser html = new HtmlParser();
            var d = html.ReadHtmlFromFile(@"C:\Users\User\Downloads\Surpass.html");
            var v = html.GetTextBySelector(d, "");

            
            
        }
    }

    public delegate void Del(string message);

    public class TestDelegate
    {
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        public static void T()
        {
            HtmlDocument doc = new HtmlDocument();
            var value = doc.DocumentNode.SelectNodes("//div")[1].Attributes["id"].Value;
        }


        Del handler = DelegateMethod;
    }
}