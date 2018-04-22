namespace STL_Auto.Services
{
    public class ConnectionString
    {
        public string GetConnectionString(string fileExtension, string Path)
        {
            switch (fileExtension.ToUpper())
            {
                case ".XLS":
                    return @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=
                                        " + Path + ";Extended Properties=\"Excel 8.0;HDR=YES;\"";
                    break;
                case ".XLSX":
                    return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=
                                        " + Path + ";Extended Properties=\"Excel 12.0;HDR=YES;\"";
                    break;
                case ".XLSM":
                    return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=
                                        " + Path + ";Extended Properties=\"Excel 12.0;HDR=YES;\"";
                    break;
                default:
                    return "none";
                    break;
            }
        }
    }
}
