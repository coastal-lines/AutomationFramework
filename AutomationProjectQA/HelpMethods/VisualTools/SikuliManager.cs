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
        }

        public Match FindMatch(ISikuliSession session, IPattern pattern)
        {
            var match = session.Find(pattern);
            return match;
        }

        public void HighlightRegion(ISikuliSession session, Region region)
        {
            session.Highlight(region, "Green");
        }
    }
}
