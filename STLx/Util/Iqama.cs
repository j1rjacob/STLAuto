using System;
using System.Data;
using System.Windows.Forms;
using STL_Auto.Util;

namespace STLx.Util
{
    public class Iqama
    {
        public Iqama()
        {
        }

        public int GetEmpIdColumn(DataTable dTable)
        {
            int columnNum = 0;
            try
            {
                foreach (DataRow dr in dTable.Rows)
                {
                    for (int i = 0; i < dTable.Columns.Count; i++)
                    {
                        if (new EmployeeIdNo().CheckMatch(dr[i].ToString().Trim()))
                        {
                            columnNum = i;
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            return columnNum;
        }
    }
}