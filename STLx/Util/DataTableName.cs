using System;
using System.Collections.Generic;
using System.IO;
using STL_Auto.Helpers;
using STL_Auto.Models;
using STL_Auto.Services;

namespace STLx.Util
{
    public class DataTableName
    {
        public DataTableName()
        {
        }

        public List<CustomTable> GetDataTableName(List<string> workSheetName, string filePath)
        {
            var ct = new List<CustomTable>();
            try
            {
                for (int i = 0; i < workSheetName.Count - 1; i++)
                {
                    var dtConnString =
                        new ConnectionString()
                            .GetConnectionString(Path.GetExtension(filePath), filePath);

                    ct.Add(new CustomTable()
                    {
                        Table = new ExcelDataTable().GetDataTable(dtConnString, "[" + workSheetName[i] + "$]"),
                        ColoumnCount = new ExcelDataTable().GetDataTable(dtConnString, "[" + workSheetName[i] + "$]").Columns.Count
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"GetDataTableName {e.Message}");
            }
            return ct;
        }
    }
}