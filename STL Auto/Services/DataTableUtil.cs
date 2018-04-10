using System;
using System.Data;

namespace STL_Auto.Services
{
    public static class DataTableUtil
    {
        public static void RemoveNull(this DataTable dt)
        {
            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
                if (dt.Rows[i][0] == DBNull.Value)
                    dt.Rows[i].Delete();
            }
            dt.AcceptChanges();
        }
    }
}
