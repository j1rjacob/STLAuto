using System;
using System.Data;

namespace STL_Auto.Services
{
    public class PayrollProof
    {
        public DataTable Payroll()
        {
            DataTable tablePayroll = new DataTable("TablePayroll");

            DataColumn iqama = new DataColumn();
            iqama.DataType = Type.GetType("System.String");
            iqama.ColumnName = "Iqama";
            tablePayroll.Columns.Add(iqama);

            DataColumn employeeName = new DataColumn();
            employeeName.DataType = Type.GetType("System.String");
            employeeName.ColumnName = "EmployeeName";
            tablePayroll.Columns.Add(employeeName);

            DataColumn project = new DataColumn();
            project.DataType = Type.GetType("System.Decimal");
            project.ColumnName = "Project";
            tablePayroll.Columns.Add(project);

            DataColumn totalEarnings = new DataColumn();
            totalEarnings.DataType = Type.GetType("System.Decimal");
            totalEarnings.ColumnName = "TotalEarnings";
            tablePayroll.Columns.Add(totalEarnings);

            DataColumn totalDeduction = new DataColumn();
            totalDeduction.DataType = Type.GetType("System.Decimal");
            totalDeduction.ColumnName = "TotalDeduction";
            tablePayroll.Columns.Add(totalDeduction);

            DataColumn netPay = new DataColumn();
            netPay.DataType = Type.GetType("System.Decimal");
            netPay.ColumnName = "NetPay";
            tablePayroll.Columns.Add(netPay);

            DataColumn creditCard = new DataColumn();
            creditCard.DataType = Type.GetType("System.Decimal");
            creditCard.ColumnName = "CreditCard";
            tablePayroll.Columns.Add(creditCard);

            DataColumn HousingAllowance = new DataColumn();
            HousingAllowance.DataType = Type.GetType("System.Decimal");
            HousingAllowance.ColumnName = "HousingAllowance";
            tablePayroll.Columns.Add(HousingAllowance);

            DataColumn transfer = new DataColumn();
            transfer.DataType = Type.GetType("System.Decimal");
            transfer.ColumnName = "Transfer";
            tablePayroll.Columns.Add(transfer);

            DataColumn cash = new DataColumn();
            cash.DataType = Type.GetType("System.Decimal");
            cash.ColumnName = "Cash";
            tablePayroll.Columns.Add(cash);

            DataColumn ones = new DataColumn();
            ones.DataType = Type.GetType("System.Int32");
            ones.ColumnName = "Ones";
            tablePayroll.Columns.Add(ones);

            DataColumn fives = new DataColumn();
            fives.DataType = Type.GetType("System.Int32");
            fives.ColumnName = "Fives";
            tablePayroll.Columns.Add(fives);

            DataColumn tens = new DataColumn();
            tens.DataType = Type.GetType("System.Int32");
            tens.ColumnName = "Tens";
            tablePayroll.Columns.Add(tens);

            DataColumn fifteens = new DataColumn();
            fifteens.DataType = Type.GetType("System.Int32");
            fifteens.ColumnName = "Fifteens";
            tablePayroll.Columns.Add(fifteens);

            DataColumn hundreds = new DataColumn();
            hundreds.DataType = Type.GetType("System.Int32");
            hundreds.ColumnName = "Hundreds";
            tablePayroll.Columns.Add(hundreds);

            DataColumn fiveHundreds = new DataColumn();
            fiveHundreds.DataType = Type.GetType("System.Int32");
            fiveHundreds.ColumnName = "FiveHundreds";
            tablePayroll.Columns.Add(fiveHundreds);

            DataColumn rowNum = new DataColumn();
            rowNum.DataType = Type.GetType("System.String");
            rowNum.ColumnName = "RowNum";
            tablePayroll.Columns.Add(rowNum);

            DataColumn[] keys = new DataColumn[1];
            keys[0] = iqama;
            tablePayroll.PrimaryKey = keys;

            return tablePayroll;
        }
    }
}
