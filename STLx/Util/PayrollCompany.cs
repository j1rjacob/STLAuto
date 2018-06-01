using System;
using System.Data;

namespace STLx.Util
{
    public class PayrollCompany
    {
        public PayrollCompany()
        {
        }

        public int GetPayrollCompany(DataTable dTable)
        {
            int columnNum = 0;
            try
            {
                foreach (DataRow dr in dTable.Rows)
                {
                    for (int i = 0; i < dTable.Columns.Count; i++)
                    {
                        if (dr[i].ToString().Trim() == "Project")
                        {
                            columnNum = i;
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Payroll Company {e.Message}");
            }
            return columnNum;
        }
    }
}