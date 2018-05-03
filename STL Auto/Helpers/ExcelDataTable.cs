using System;
using System.Data;
using System.Data.OleDb;

namespace STL_Auto.Helpers
{
    public class ExcelDataTable
    {
        public DataTable GetDataTable(string ConnString, string table)
        {
            OleDbConnection objConn = new OleDbConnection();
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataTable dtExcel = new DataTable();
            try
            {
                objConn = new OleDbConnection(ConnString);
                objConn.Open();
                da = new OleDbDataAdapter("SELECT * FROM " + table, objConn);
                da.Fill(dtExcel);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if (da != null)
                {
                    da.Dispose();
                }

                if (objConn != null)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
            }
            return dtExcel;
        }
    }
}
