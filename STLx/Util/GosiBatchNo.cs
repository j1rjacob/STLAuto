using System;
using System.Windows.Forms;

namespace STLx.Util
{
    public class GosiBatchNo
    {
        public GosiBatchNo()
        {
        }

        public int GetGosiBatchNoColumn(DataGridView dgView)
        {
            int columnNum = 0;
            try
            {
                foreach (DataGridViewColumn column in dgView.Columns)
                {
                    if (column.HeaderText == "الرقم الوظيفي بالمنشأة")
                    {
                        columnNum = column.Index;
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Gosi Batch No. {e.Message}");
            }
            return columnNum;
        }
    }
}