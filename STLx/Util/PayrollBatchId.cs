using System;
using System.Data;

namespace STLx.Util
{
    public class PayrollBatchId
    {
        public PayrollBatchId()
        {
        }

        public int GetPayrollBatchIdColumn(DataTable dTable)
        {
            int columnNum = 0;
            try
            {
                foreach (DataRow dr in dTable.Rows)
                {
                    for (int i = 0; i < dTable.Columns.Count; i++)
                    {
                        if (dr[i].ToString().Trim() == "Emp. ID")
                        {
                            columnNum = i;
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"PayrollBatchId {e.Message}");
            }
            return columnNum;
        }
    }
}