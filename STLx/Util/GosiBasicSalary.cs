using System;
using System.Windows.Forms;

namespace STLx.Util
{
    public class GosiBasicSalary
    {
        public GosiBasicSalary()
        {
        }

        public int GetGosiBasicSalaryColumn(DataGridView dgView)
        {
            int columnNum = 0;
            try
            {
                foreach (DataGridViewColumn column in dgView.Columns)
                {
                    if (column.HeaderText == "الأجر الأساسي")
                    {
                        columnNum = column.Index;
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Gosi Basic Salary {e.Message}");
            }
            return columnNum;
        }
    }
}