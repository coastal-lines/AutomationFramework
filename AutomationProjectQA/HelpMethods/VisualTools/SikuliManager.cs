using SikuliSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProjectQA.HelpMethods.VisualTools
{
    public class SikuliManager
    {
        public void CreateSikuliSession()
        {
            var im3 = Patterns.FromFile(@"C:\\Sikuli\WrongSpellingWord7.png", 0.9f);
            var session = Sikuli.CreateSession();
            var match = session.Find(im3);
            var region = new SikuliSharp.Region(match.GetX(), match.GetY(), match.GetW(), match.GetH());
            session.Highlight(region, "Green");
        }
    }
}
