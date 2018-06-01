using System;
using System.Windows.Forms;

namespace STLx.Util
{
    public class SmallSalariesSalaryAmnt
    {
        public SmallSalariesSalaryAmnt()
        {
        }

        public int GetSmallSalariesSalaryAmntColumn(DataGridView dgView)
        {
            int columnNum = 0;
            try
            {
                foreach (DataGridViewColumn column in dgView.Columns)
                {
                    if (column.HeaderText == "Salary_Amount")
                    {
                        columnNum = column.Index;
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"SmallSalariesSalaryAmnt {e.Message}");
            }
            return columnNum;
        }
    }
}