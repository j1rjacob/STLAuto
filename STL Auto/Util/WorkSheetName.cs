using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace STL_Auto.Util
{
    public class WorkSheetName
    {
        public IEnumerable<string> Get(string path)
        {
            IEnumerable<string> wsNames = null;
            var fileinfo = new FileInfo(path);
            if (fileinfo.Exists)
            {
                using (var package = new ExcelPackage(fileinfo))
                {
                    wsNames = package.Workbook.Worksheets.Select(x => x.Name);
                }
            }
            return wsNames;
        } 
    }
}
