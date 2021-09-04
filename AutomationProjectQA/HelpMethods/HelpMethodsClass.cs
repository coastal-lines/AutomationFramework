using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProjectQA.HelpMethods
{
    internal class HelpMethodsClass
    {
        private HtmlParser _htmlParser;

        public HtmlParser htmlParser => _htmlParser ?? (_htmlParser = new HtmlParser());
    }
}
