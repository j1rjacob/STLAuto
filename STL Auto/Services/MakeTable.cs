using System;
using System.Data;

namespace STL_Auto.Services
{
    public static class MakeTable
    {
        public static DataTable BigSalaries()
        {
            DataTable newBigSalaries = new DataTable("TableBigSalaries");

            DataColumn iqama = new DataColumn();
            iqama.DataType = Type.GetType("System.String");
            iqama.ColumnName = "Iqama";
            newBigSalaries.Columns.Add(iqama);

            DataColumn batchNo = new DataColumn();
            batchNo.DataType = Type.GetType("System.String");
            batchNo.ColumnName = "BatchNo";
            newBigSalaries.Columns.Add(batchNo);

            DataColumn Aesthetic = new DataColumn();
            Aesthetic.DataType = Type.GetType("System.Decimal");
            Aesthetic.ColumnName = "Aesthetic";
            newBigSalaries.Columns.Add(Aesthetic);

            DataColumn Payroll = new DataColumn();
            Payroll.DataType = Type.GetType("System.Decimal");
            Payroll.ColumnName = "Payroll";
            newBigSalaries.Columns.Add(Payroll);

            DataColumn Bank = new DataColumn();
            Bank.DataType = Type.GetType("System.Decimal");
            Bank.ColumnName = "Bank";
            newBigSalaries.Columns.Add(Bank);

            DataColumn Cash = new DataColumn();
            Cash.DataType = Type.GetType("System.Decimal");
            Cash.ColumnName = "Cash";
            newBigSalaries.Columns.Add(Cash);

            DataColumn BasicSalary = new DataColumn();
            BasicSalary.DataType = Type.GetType("System.Decimal");
            BasicSalary.ColumnName = "BasicSalary";
            newBigSalaries.Columns.Add(BasicSalary);

            DataColumn HousingAllowance = new DataColumn();
            HousingAllowance.DataType = Type.GetType("System.Decimal");
            HousingAllowance.ColumnName = "HousingAllowance";
            newBigSalaries.Columns.Add(HousingAllowance);

            DataColumn OtherEarnings = new DataColumn();
            OtherEarnings.DataType = Type.GetType("System.Decimal");
            OtherEarnings.ColumnName = "OtherEarnings";
            newBigSalaries.Columns.Add(OtherEarnings);

            DataColumn rowNum = new DataColumn();
            rowNum.DataType = Type.GetType("System.String");
            rowNum.ColumnName = "RowNum";
            newBigSalaries.Columns.Add(rowNum);

            DataColumn[] keys = new DataColumn[1];
            keys[0] = iqama;
            newBigSalaries.PrimaryKey = keys;
            
            return newBigSalaries;
        }
    }
}
