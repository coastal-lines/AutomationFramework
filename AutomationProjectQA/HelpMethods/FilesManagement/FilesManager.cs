using System;
using System.Collections.Generic;
using System.IO;

namespace AutomationProjectQA.HelpMethods.FilesManagement
{
    public class FilesManager
    {
        public string ReadTxtFile(string filePath)
        {
            string text = "";

            try
            {
                StreamReader sr = new StreamReader(filePath);
                text = sr.ReadLine();

                while (text != null)
                {
                    text = sr.ReadLine();
                }

                sr.Close();
            }
            catch (FileNotFoundException errorMsg)
            {
                Console.WriteLine("Exception: " + errorMsg.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            return text;
        }

        public void SaveTxtFile(string filePath, string text)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filePath);
                sw.WriteLine(text);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public void SaveTxtFile(string filePath, string[] text)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filePath);

                for (int i = 0; i < text.Length; i++)
                {
                    sw.WriteLine(text[i]);
                }

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public void SaveTxtFile(string filePath, List<string> text)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filePath);

                for (int i = 0; i < text.Count; i++)
                {
                    sw.WriteLine(text[i]);
                }

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
