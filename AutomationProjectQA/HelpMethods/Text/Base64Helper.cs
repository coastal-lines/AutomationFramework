using System;
using System.IO;

namespace AutomationProjectQA.HelpMethods
{
    public class Base64Helper
    {
        public string ConvertFileToBS64(string filePath)
        {
            string[] text = File.ReadAllLines($"{filePath}");

            byte[] byteArray = new byte[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                byteArray[i] = Convert.ToByte(byteArray[i]);
            }

            string base64String = Convert.ToBase64String(byteArray);
            return base64String;
        }

        public string StringToBase64Encode(string text)
        {
            var textBase64 = System.Text.Encoding.UTF8.GetBytes(text);
            return System.Convert.ToBase64String(textBase64);
        }

        public string Base64TextDecode(string textInBase64)
        {
            var encodedText = System.Convert.FromBase64String(textInBase64);
            return System.Text.Encoding.UTF8.GetString(encodedText);
        }
    }
}
