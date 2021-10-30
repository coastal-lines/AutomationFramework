using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProjectQA.HelpMethods.Office
{
    public class CSV
    {
        private List<string> GetAllCellsFromCsvFile(string filePath)
        {
            var cellsList = new List<string>();
            using (var reader = new StreamReader(filePath))
            {
                string[] rows;

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    rows = line.Split(';');
                    foreach (var row in rows)
                    {
                        var cells = row.Split(',');
                        foreach (var cell in cells)
                        {
                            cellsList.Add(cell.Replace("\"", "").Replace("\\", ""));
                        }
                    }
                }
            }

            return cellsList;
        }
    }
}
