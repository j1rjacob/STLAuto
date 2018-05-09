using System;
using System.Data;

namespace STL_Auto.Services
{
    public class MakeTable
    {
        public DataTable BigSalaries()
        {
            DataTable newBigSalaries = new DataTable("TableBigSalaries");

            DataColumn iqama = new DataColumn();
            iqama.DataType = Type.GetType("System.String");
            iqama.ColumnName = "Iqama"; //0
            newBigSalaries.Columns.Add(iqama);

            DataColumn batchNo = new DataColumn();
            batchNo.DataType = Type.GetType("System.String");
            batchNo.ColumnName = "BatchNo"; //1
            newBigSalaries.Columns.Add(batchNo);

            DataColumn Aesthetic = new DataColumn();
            Aesthetic.DataType = Type.GetType("System.Decimal");
            Aesthetic.ColumnName = "Aesthetic"; //2
            newBigSalaries.Columns.Add(Aesthetic);

            DataColumn Payroll = new DataColumn();
            Payroll.DataType = Type.GetType("System.Decimal");
            Payroll.ColumnName = "Payroll"; //3
            newBigSalaries.Columns.Add(Payroll);

            DataColumn Bank = new DataColumn();
            Bank.DataType = Type.GetType("System.Decimal");
            Bank.ColumnName = "Bank"; //4
            newBigSalaries.Columns.Add(Bank);

            DataColumn Cash = new DataColumn();
            Cash.DataType = Type.GetType("System.Decimal");
            Cash.ColumnName = "Cash"; //5
            newBigSalaries.Columns.Add(Cash);

            DataColumn BasicSalary = new DataColumn();
            BasicSalary.DataType = Type.GetType("System.Decimal");
            BasicSalary.ColumnName = "BasicSalary"; //6
            newBigSalaries.Columns.Add(BasicSalary);

            DataColumn HousingAllowance = new DataColumn();
            HousingAllowance.DataType = Type.GetType("System.Decimal");
            HousingAllowance.ColumnName = "HousingAllowance"; //7
            newBigSalaries.Columns.Add(HousingAllowance);

            DataColumn OtherEarnings = new DataColumn();
            OtherEarnings.DataType = Type.GetType("System.Decimal");
            OtherEarnings.ColumnName = "OtherEarnings"; //8
            newBigSalaries.Columns.Add(OtherEarnings);

            DataColumn rowNum = new DataColumn();
            rowNum.DataType = Type.GetType("System.String");
            rowNum.ColumnName = "RowNum"; //9
            newBigSalaries.Columns.Add(rowNum);

            DataColumn empName = new DataColumn();
            empName.DataType = Type.GetType("System.String");
            empName.ColumnName = "Name"; //10
            newBigSalaries.Columns.Add(empName);

            DataColumn Credit = new DataColumn();
            Credit.DataType = Type.GetType("System.Decimal");
            Credit.ColumnName = "Credit"; //11
            newBigSalaries.Columns.Add(Credit);

            DataColumn Transfer = new DataColumn();
            Transfer.DataType = Type.GetType("System.Decimal");
            Transfer.ColumnName = "Transfer"; //12
            newBigSalaries.Columns.Add(Transfer);

            DataColumn Company = new DataColumn();
            Company.DataType = Type.GetType("System.String");
            Company.ColumnName = "Company"; //13
            newBigSalaries.Columns.Add(Company);

            DataColumn[] keys = new DataColumn[1];
            keys[0] = iqama;
            newBigSalaries.PrimaryKey = keys;
            
            return newBigSalaries;
        }
    }
}
