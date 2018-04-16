using System;

namespace STL_Auto.Util
{
    public class ExcelConvert
    {
        public static bool ConvertXlsx(string filename, string filePath)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application
                {
                    Visible = false
                };
                Microsoft.Office.Interop.Excel.Workbook eWorkbook = excelApp.Workbooks.Open(filePath + "\\" + filename + ".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                eWorkbook.SaveAs(filePath + "\\" + filename + ".xlsx", Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                eWorkbook.Close(false, Type.Missing, Type.Missing);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
                throw;
            }
        }
    }
}
