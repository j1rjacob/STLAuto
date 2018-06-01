using System;
using System.Windows.Forms;

namespace STLx.Util
{
    public class GosiAesthetic
    {
        public GosiAesthetic()
        {
        }

        public int GetGosiAestheticColumn(DataGridView dgView)
        {
            int columnNum = 0;
            try
            {
                foreach (DataGridViewColumn column in dgView.Columns)
                {
                    if (column.HeaderText == "الجمالي بعد البدلات")
                    {
                        columnNum = column.Index;
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"GetGosiAestheticColumn {e.Message}");
            }
            return columnNum;
        }
    }
}