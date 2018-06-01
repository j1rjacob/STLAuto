using System;
using System.Windows.Forms;

namespace STLx.Util
{
    public class HousingAllowance
    {
        public HousingAllowance()
        {
        }

        public int GetHousingAllowanceColumn(DataGridView dgView)
        {
            int columnNum = 0;
            try
            {
                foreach (DataGridViewColumn column in dgView.Columns)
                {
                    if (column.HeaderText == "بدل السكن الشهري")
                    {
                        columnNum = column.Index;
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Housing Allowance {e.Message}");
            }
            return columnNum;
        }
    }
}