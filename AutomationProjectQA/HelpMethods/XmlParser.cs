using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AutomationProjectQA.HelpMethods
{
    public class XmlParser
    {
        public XmlElement LoadXmlFromFileAndGetRoot(string filePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);
            XmlElement xmlRoot = xmlDoc.DocumentElement;

            return xmlRoot;
        }
    }
}
