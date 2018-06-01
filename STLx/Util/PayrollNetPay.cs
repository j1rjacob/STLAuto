using System;
using System.Data;

namespace STLx.Util
{
    public class PayrollNetPay
    {
        public PayrollNetPay()
        {
        }

        public int GetPayrollNetPay(DataTable dTable)
        {
            int columnNum = 0;
            try
            {
                foreach (DataRow dr in dTable.Rows)
                {
                    for (int i = 0; i < dTable.Columns.Count; i++)
                    {
                        if (dr[i].ToString().Trim() == "Net Pay")
                        {
                            columnNum = i;
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"PayrollNetPay {e.Message}");
            }
            return columnNum;
        }
    }
}