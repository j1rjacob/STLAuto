using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace STLx
{
    public class WorkSheetName
    {
        public WorkSheetName()
        {
        }

        public List<string> GetWorkSheetName(string path)
        {
            var wsName = new List<string>();
            try
            {
                var fileinfo = new FileInfo(path);
                if (fileinfo.Exists)
                {
                    using (var package = new ExcelPackage(fileinfo))
                    {
                        package.Workbook.Worksheets.Add("Halla"); //WorkAround for list lol...
                        var ws = package.Workbook.Worksheets.Select(x => x.Name);
                        foreach (var sheet in ws)
                        {
                            wsName.Add(sheet);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"WorkSheetName {ex.Message}");
            }
            return wsName;
        }
    }
}