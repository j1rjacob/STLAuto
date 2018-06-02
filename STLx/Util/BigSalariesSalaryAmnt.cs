using System;
using System.Data;

namespace STLx.Util
{
    public class BigSalariesSalaryAmnt
    {
        public BigSalariesSalaryAmnt()
        {
        }

        public int GetBigSalariesSalaryAmntColumn(DataTable dTable)
        {
            int columnNum = 0;
            try
            {
                foreach (DataRow dr in dTable.Rows)
                {
                    for (int i = 0; i < dTable.Columns.Count; i++)
                    {
                        if (dr[i].ToString().Trim() == "Salary Amount")
                        {
                            columnNum = i;
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"GetBigSalariesSalaryAmntColumn {e.Message}");
            }
            return columnNum;
        }
    }
}