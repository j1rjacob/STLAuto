using System;
using System.Windows.Forms;

namespace STLx.Util
{
    public class OtherEarnings
    {
        public OtherEarnings()
        {
        }

        public int GetOtherEarningsColumn(DataGridView dgView)
        {
            int columnNum = 0;
            try
            {
                foreach (DataGridViewColumn column in dgView.Columns)
                {
                    if (column.HeaderText == "بدلات أخرى")
                    {
                        columnNum = column.Index;
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"OtherEarnings {e.Message}");
            }
            return columnNum;
        }
    }
}