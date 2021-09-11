using SikuliSharp;

namespace AutomationProjectQA.HelpMethods.VisualTools
{
    public class SikuliManager
    {
        public ISikuliSession CreateSikuliSession()
        {
            var session = Sikuli.CreateSession();
            return session;
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

        public IPattern GetPattern(float similarity = 0.9f)
        {
            var pattern = Patterns.FromFile(@"C:\\Sikuli\WrongSpellingWord7.png", similarity);
            return pattern;
        }

        public bool IsPatternExisted(ISikuliSession session, IPattern pattern)
        {
            var isVisible = session.Exists(pattern);
            return isVisible;
        }
    }
}
