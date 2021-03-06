﻿using OfficeOpenXml;
using OfficeOpenXml.Style;
using STL_Auto.Services;
using STL_Auto.Util;
using STLx.Data;
using STLx.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace STLx
{
    public partial class FormAuto : Form
    {
        public FormAuto()
        {
            InitializeComponent();
        }
        private void buttonPayroll_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.Filter = "Excel files|*.xls;*.xlsx";
                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    textBoxPayroll.Text = openFileDialog.FileName;
                }
                var filename = Path.GetFileNameWithoutExtension(openFileDialog.SafeFileName);
                string currentDirectory = Path.GetDirectoryName(openFileDialog.FileName);
                string filePath = Path.GetFullPath(currentDirectory);
                if (new ExcelConvert().ConvertXlsx(filename, filePath))
                {
                    textBoxPayroll.Text = filePath + "\\" + filename + ".xlsx";
                    buttonPayroll.BackColor = Color.SaddleBrown;
                }
                else
                {
                    MessageBox.Show("Invalid file");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonGosi_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.Filter = "Excel files|*.xls;*.xlsx";
                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    textBoxGosi.Text = openFileDialog.FileName;
                }

                var filename = Path.GetFileNameWithoutExtension(openFileDialog.SafeFileName);
                string currentDirectory = Path.GetDirectoryName(openFileDialog.FileName);
                string filePath = Path.GetFullPath(currentDirectory);

                if (new ExcelConvert().ConvertXlsx(filename, filePath))
                {
                    textBoxGosi.Text = filePath + "\\" + filename + ".xlsx";
                    buttonGosi.BackColor = Color.SaddleBrown;
                }
                else
                {
                    MessageBox.Show("Invalid file");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonBig_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.Filter = "Excel files|*.xls;*.xlsx;*.xlsm";
                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    textBoxBig.Text = openFileDialog.FileName;
                }

                var filename = Path.GetFileNameWithoutExtension(openFileDialog.SafeFileName);
                string currentDirectory = Path.GetDirectoryName(openFileDialog.FileName);
                string filePath = Path.GetFullPath(currentDirectory);

                if (new ExcelConvert().ConvertXlsx(filename, filePath))
                {
                    textBoxBig.Text = filePath + "\\" + filename + ".xlsx";
                    buttonBig.BackColor = Color.SaddleBrown;
                }
                else
                {
                    MessageBox.Show("Invalid file");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonSmall_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.Filter = "Excel files|*.xls;*.xlsx;*.xlsm";
                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    textBoxSmall.Text = openFileDialog.FileName;
                }

                var filename = Path.GetFileNameWithoutExtension(openFileDialog.SafeFileName);
                string currentDirectory = Path.GetDirectoryName(openFileDialog.FileName);
                string filePath = Path.GetFullPath(currentDirectory);

                if (new ExcelConvert().ConvertXlsx(filename, filePath))
                {
                    textBoxSmall.Text = filePath + "\\" + filename + ".xlsx";
                    buttonSmall.BackColor = Color.SaddleBrown;
                }
                else
                {
                    MessageBox.Show("Invalid file");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            toolStripProgressBar.Style = ProgressBarStyle.Marquee;
            toolStripProgressBar.MarqueeAnimationSpeed = 30;
            //Task.Run(() => );
            try
            {
                if (textBoxSmall.Text != ""
                && textBoxBig.Text != ""
                && textBoxGosi.Text != ""
                && textBoxPayroll.Text != ""
                && TextBoxPaymentDescription.Text != "")
                {
                    var dtBigSalaries = new MakeTable().BigSalaries();
                    var dtSmallSalaries = new MakeTable().BigSalaries();

                    DataTable dtPayroll = null;
                    DataTable dtGosi = null;
                    DataTable dtBig = null;
                    DataTable dtSmall = null;

                    #region BigSalaries
                    var filePath = textBoxBig.Text;
                    var ctsB = new DataTableName().GetDataTableName(new WorkSheetName().GetWorkSheetName(filePath), filePath);

                    foreach (var ct in ctsB)
                    {
                        if (ct.ColoumnCount >= 13)
                        {
                            dtBig = ct.Table;
                            break;
                        }
                    }

                    var empIdIndexBigSalary = new Iqama().GetEmpIdColumn(dtBig);
                    foreach (DataRow dr in dtBig.Rows)
                    {
                        for (int i = 0; i < dtBig.Columns.Count; i++)
                        {
                            if (new EmployeeIdNo().CheckMatch(dr[empIdIndexBigSalary].ToString().Trim()))
                            {
                                dtBigSalaries.Rows.Add(dr[empIdIndexBigSalary].ToString().Trim(), "", 0m, 0m, 0m, 0m,
                                    0m, 0m, 0m, dtBig.Rows.IndexOf(dr).ToString(), dr[empIdIndexBigSalary + 1].ToString().Trim(), 0m, 0m, "");
                                break;
                            }
                        }
                    }
                    #endregion

                    #region SmallSalaries
                    var filePathS = textBoxSmall.Text;
                    var ctsS = new DataTableName().GetDataTableName(new WorkSheetName().GetWorkSheetName(filePathS), filePathS);

                    foreach (var ct in ctsS)
                    {
                        if (ct.ColoumnCount == 9)
                        {
                            dtSmall = ct.Table;
                            break;
                        }
                    }

                    dataGridView3.DataSource = dtSmall;

                    foreach (DataRow dr in dtSmall.Rows) //TODO: get data from dbase not in excel wobank
                    {
                        for (int i = 0; i < dtSmall.Columns.Count; i++)
                        {
                            if (new EmployeeIdNo().CheckMatch(dr[i].ToString().Trim()))
                            {
                                dtSmallSalaries.Rows.Add(dr[i].ToString().Trim(), dr[i - 3].ToString().Trim(), 0m, 0m, 0m,
                                    0m, 0m, 0m, 0m, dtSmall.Rows.IndexOf(dr).ToString(), dr[i - 1].ToString().Trim(), 0m, 0m, "");
                                break;
                            }
                        }
                    }
                    #endregion

                    #region Gosi
                    filePath = textBoxGosi.Text;
                    var ctsG = new DataTableName().GetDataTableName(new WorkSheetName().GetWorkSheetName(filePath), filePath);

                    foreach (var ct in ctsG)
                    {
                        if (ct.ColoumnCount == 14)
                        {
                            dtGosi = ct.Table;
                            break;
                        }
                    }

                    dataGridView2.DataSource = dtGosi;

                    var empIdIndexGosi = new Iqama().GetEmpIdColumn(dtGosi);
                    var batchNoIndexGosi = new GosiBatchNo().GetGosiBatchNoColumn(dataGridView2);
                    var aestheticIndexGosi = new GosiAesthetic().GetGosiAestheticColumn(dataGridView2);
                    var basicSalaryIndexGosi = new GosiBasicSalary().GetGosiBasicSalaryColumn(dataGridView2);
                    var housingAllowanceIndexGosi = new HousingAllowance().GetHousingAllowanceColumn(dataGridView2);
                    var otherEarningsIndexGosi = new OtherEarnings().GetOtherEarningsColumn(dataGridView2);

                    var EmpIdIndexBigSalaries = 0;
                    Int64 emplIdValueGosi;

                    //BIG
                    foreach (DataRow dr in dtGosi.Rows) //TODO: compare batch no or iqama 
                    {
                        if (Int64.TryParse(dr[empIdIndexGosi].ToString().Trim(), out emplIdValueGosi))
                        {
                            DataRow row = dtBigSalaries.Select("Iqama ='" + emplIdValueGosi + "'").FirstOrDefault();

                            if (row != null)
                            {
                                if (row["BatchNo"] == null)
                                {
                                    dr[batchNoIndexGosi].ToString();
                                }

                                row["BatchNo"] = Convert.ToDecimal(dr[batchNoIndexGosi] == DBNull.Value
                                    ? 0
                                    : dr[batchNoIndexGosi]);

                                row["Aesthetic"] = Convert.ToDecimal(dr[aestheticIndexGosi] == DBNull.Value
                                    ? 0
                                    : dr[aestheticIndexGosi]);
                                row["BasicSalary"] = Convert.ToDecimal(dr[basicSalaryIndexGosi] == DBNull.Value
                                    ? 0
                                    : dr[basicSalaryIndexGosi]);
                                row["HousingAllowance"] = Convert.ToDecimal(dr[housingAllowanceIndexGosi] == DBNull.Value
                                    ? 0
                                    : dr[housingAllowanceIndexGosi]);
                                row["OtherEarnings"] = Convert.ToDecimal(dr[otherEarningsIndexGosi] == DBNull.Value
                                    ? 0
                                    : dr[otherEarningsIndexGosi]);

                                dtBigSalaries.AcceptChanges();
                            }
                        }
                    }

                    //SMALL 
                    foreach (DataRow dr in dtGosi.Rows) //TODO: compare batch no or iqama
                    {
                        if (Int64.TryParse(dr[empIdIndexGosi].ToString().Trim(), out emplIdValueGosi))
                        {
                            DataRow row = dtSmallSalaries.Select("Iqama ='" + emplIdValueGosi + "'").FirstOrDefault();

                            if (row != null)
                            {
                                if (row["BatchNo"] == null)
                                {
                                    dr[batchNoIndexGosi].ToString();
                                }

                                row["Aesthetic"] = Convert.ToDecimal(dr[aestheticIndexGosi] == DBNull.Value
                                    ? 0
                                    : dr[aestheticIndexGosi]);
                                row["BasicSalary"] = Convert.ToDecimal(dr[basicSalaryIndexGosi] == DBNull.Value
                                    ? 0
                                    : dr[basicSalaryIndexGosi]);
                                row["HousingAllowance"] = Convert.ToDecimal(dr[housingAllowanceIndexGosi] == DBNull.Value
                                    ? 0
                                    : dr[housingAllowanceIndexGosi]);
                                row["OtherEarnings"] = Convert.ToDecimal(dr[otherEarningsIndexGosi] == DBNull.Value
                                    ? 0
                                    : dr[otherEarningsIndexGosi]);

                                dtSmallSalaries.AcceptChanges();
                            }
                        }
                    }
                    #endregion

                    #region PayrollBigSalary
                    filePath = textBoxPayroll.Text;
                    var ctsPB = new DataTableName().GetDataTableName(new WorkSheetName().GetWorkSheetName(filePath), filePath);

                    foreach (var ct in ctsPB)
                    {
                        if (ct.ColoumnCount == 22)
                        {
                            dtPayroll = ct.Table;
                            break;
                        }
                    }

                    var netPayPayrollPB = new PayrollNetPay().GetPayrollNetPay(dtPayroll);
                    var companyPayrollPB = new PayrollCompany().GetPayrollCompany(dtPayroll);
                    var batchIDPayrollPB = new PayrollBatchId().GetPayrollBatchIdColumn(dtPayroll);

                    Int64 batchIdPB;
                    var payrollPB = new Dictionary<string, string>();
                    decimal salaryBig = 0m;
                    foreach (DataRow dr in dtPayroll.Rows)
                    {
                        if (Int64.TryParse(dr[batchIDPayrollPB].ToString().Replace(".00", "").Replace(",", "").Trim(),
                            out batchIdPB))
                        {
                            DataRow row = dtBigSalaries.Select("BatchNo ='" + batchIdPB + "'").FirstOrDefault();
                            if (row != null)
                            {
                                //Check Duplicate here remove then add again
                                if (!payrollPB.ContainsKey(row["Iqama"].ToString()))
                                {
                                    payrollPB.Add(row["Iqama"].ToString(), dr[netPayPayrollPB].ToString());

                                    salaryBig = Convert.ToDecimal(dr[netPayPayrollPB]);
                                    row["Bank"] =
                                        Convert.ToDecimal(dr[netPayPayrollPB]) >= Convert.ToDecimal(row["Aesthetic"])
                                            ? Convert.ToDecimal(row["Aesthetic"])
                                            : Convert.ToDecimal(dr[netPayPayrollPB]);
                                    row["Transfer"] =
                                        Convert.ToDecimal(dr[netPayPayrollPB]) >= Convert.ToDecimal(row["Aesthetic"])
                                            ? Convert.ToDecimal(row["Aesthetic"])
                                            : Convert.ToDecimal(dr[netPayPayrollPB]);
                                    row["Cash"] =
                                        (Convert.ToDecimal(salaryBig) - Convert.ToDecimal(row["Aesthetic"])) < 0
                                            ? 0
                                            : (Convert.ToDecimal(salaryBig) - Convert.ToDecimal(row["Aesthetic"]));
                                }
                                else
                                {
                                    var firstSalary = payrollPB.SingleOrDefault(x => x.Key == row["Iqama"].ToString());
                                    salaryBig = Convert.ToDecimal(dr[netPayPayrollPB]) +
                                                Convert.ToDecimal(firstSalary.Value);

                                    payrollPB.Remove(firstSalary.Key);
                                    payrollPB.Add(firstSalary.Key, salaryBig.ToString());

                                    row["Bank"] = Convert.ToDecimal(salaryBig) >= Convert.ToDecimal(row["Aesthetic"])
                                        ? Convert.ToDecimal(row["Aesthetic"])
                                        : Convert.ToDecimal(salaryBig);
                                    row["Transfer"] = Convert.ToDecimal(salaryBig) >= Convert.ToDecimal(row["Aesthetic"])
                                        ? Convert.ToDecimal(row["Aesthetic"])
                                        : Convert.ToDecimal(salaryBig);
                                    row["Cash"] = (Convert.ToDecimal(salaryBig) - Convert.ToDecimal(row["Aesthetic"])) < 0
                                        ? 0
                                        : (Convert.ToDecimal(salaryBig) - Convert.ToDecimal(row["Aesthetic"]));
                                }
                                row["Payroll"] = salaryBig;
                                row["Company"] = dr[companyPayrollPB];
                                dtBigSalaries.AcceptChanges();
                            }
                        }
                    }
                    #endregion

                    var salaryAmountBig = new BigSalariesSalaryAmnt().GetBigSalariesSalaryAmntColumn(dtBig);

                    UpdateBigSalaries(dtBigSalaries, textBoxBig.Text, salaryAmountBig + 1);

                    #region PayrollSmallSalary
                    filePath = textBoxPayroll.Text;
                    var ctsPS = new DataTableName().GetDataTableName(new WorkSheetName().GetWorkSheetName(filePath), filePath);

                    foreach (var ct in ctsPS)
                    {
                        if (ct.ColoumnCount == 22)
                        {
                            dtPayroll = ct.Table;
                            break;
                        }
                    }

                    var netPayPayrollSB = new PayrollNetPay().GetPayrollNetPay(dtPayroll);
                    var companyPayrollSB = new PayrollCompany().GetPayrollCompany(dtPayroll);
                    var batchIDPayrollSB = new PayrollBatchId().GetPayrollBatchIdColumn(dtPayroll);

                    Int64 batchIdSB;
                    var payroll = new Dictionary<string, string>();
                    foreach (DataRow dr in dtPayroll.Rows)
                    {
                        if (Int64.TryParse(dr[batchIDPayrollSB].ToString().Replace(".00", "").Replace(",", "").Trim(),
                            out batchIdSB))
                        {
                            DataRow row = dtSmallSalaries.Select("BatchNo ='" + batchIdSB + "'").FirstOrDefault();

                            if (row != null)
                            {
                                if (!payroll.ContainsKey(row["Iqama"].ToString()))
                                {
                                    payroll.Add(row["Iqama"].ToString(), dr[netPayPayrollSB].ToString());
                                    row["Payroll"] = Convert.ToDecimal(dr[netPayPayrollSB]);
                                    var sal = Convert.ToDecimal(dr[netPayPayrollSB]);
                                    row["Bank"] =
                                        Convert.ToDecimal(dr[netPayPayrollSB]) >= Convert.ToDecimal(row["Aesthetic"])
                                            ? Convert.ToDecimal(row["Aesthetic"])
                                            : Convert.ToDecimal(dr[netPayPayrollSB]);
                                    row["Credit"] =
                                        Convert.ToDecimal(dr[netPayPayrollSB]) >= Convert.ToDecimal(row["Aesthetic"])
                                            ? Convert.ToDecimal(row["Aesthetic"])
                                            : Convert.ToDecimal(dr[netPayPayrollSB]);
                                    row["Cash"] =
                                        (Convert.ToDecimal(sal) - Convert.ToDecimal(row["Aesthetic"])) < 0
                                            ? 0
                                            : (Convert.ToDecimal(sal) - Convert.ToDecimal(row["Aesthetic"]));
                                }
                                else
                                {
                                    var firstSalary = payroll.SingleOrDefault(x => x.Key == row["Iqama"].ToString());
                                    var salary = Convert.ToDecimal(dr[netPayPayrollSB]) +
                                                 Convert.ToDecimal(firstSalary.Value);
                                    payroll.Remove(firstSalary.Key);
                                    payroll.Add(firstSalary.Key, salary.ToString());

                                    row["Payroll"] = salary;

                                    row["Bank"] = Convert.ToDecimal(salary) >= Convert.ToDecimal(row["Aesthetic"])
                                        ? Convert.ToDecimal(row["Aesthetic"])
                                        : Convert.ToDecimal(salary);

                                    row["Credit"] = Convert.ToDecimal(salary) >= Convert.ToDecimal(row["Aesthetic"])
                                        ? Convert.ToDecimal(row["Aesthetic"])
                                        : Convert.ToDecimal(salary);

                                    row["Cash"] = (Convert.ToDecimal(salary) - Convert.ToDecimal(row["Aesthetic"])) < 0
                                        ? 0
                                        : (Convert.ToDecimal(salary) - Convert.ToDecimal(row["Aesthetic"]));
                                }
                                row["Company"] = dr[companyPayrollSB];
                                dtSmallSalaries.AcceptChanges();
                            }
                        }
                    }
                    #endregion

                    var dtAll = (dtBigSalaries.AsEnumerable().Union(dtSmallSalaries.AsEnumerable(),
                        DataRowComparer.Default)).CopyToDataTable();

                    dataGridView1.DataSource = dtAll;

                    var salaryAmountSmall = new SmallSalariesSalaryAmnt().GetSmallSalariesSalaryAmntColumn(dataGridView3);

                    UpdateSmallSalaries(dtSmallSalaries, textBoxSmall.Text, salaryAmountSmall + 1);

                    ShadeBorder(textBoxSmall.Text, dtBigSalaries.Rows.Count + dtSmallSalaries.Rows.Count - 3, dtBigSalaries,
                        dtSmallSalaries);

                    Summary(textBoxSmall.Text, dtAll, dtSmallSalaries, dtBigSalaries);

                    buttonCalculate.BackColor = Color.SaddleBrown;

                    DialogResult dialogResult =
                        MessageBox.Show("Calcution finished, Again?", "TMF", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        buttonCalculate.BackColor = Color.Green;
                        buttonSmall.BackColor = Color.Green;
                        buttonBig.BackColor = Color.Green;
                        buttonGosi.BackColor = Color.Green;
                        buttonPayroll.BackColor = Color.Green;

                        textBoxSmall.Clear();
                        textBoxBig.Clear();
                        textBoxGosi.Clear();
                        textBoxPayroll.Clear();
                        TextBoxPaymentDescription.Clear();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Ok");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill up all fields.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Admin", MessageBoxButtons.OK);
            }

            toolStripProgressBar.Style = ProgressBarStyle.Continuous;
            toolStripProgressBar.MarqueeAnimationSpeed = 0;
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }
        private void UpdateBigSalaries(DataTable dt, string xPath, int salaryAmntCol)
        {
            try
            {
                int tableNum = 0;
                int counter = 1;
                var filePath = textBoxBig.Text;
                var ctsB = new DataTableName().GetDataTableName(new WorkSheetName().GetWorkSheetName(filePath), filePath);

                foreach (var ct in ctsB)
                {
                    if (ct.ColoumnCount >= 13)
                    {
                        tableNum = counter;
                        break;
                    }
                    counter++;
                }

                var fileinfo = new FileInfo(xPath);
                if (fileinfo.Exists)
                {
                    using (ExcelPackage excelPackage = new ExcelPackage(fileinfo))
                    {
                        Int64 value;
                        ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[tableNum]; //todo make dynamic
                        foreach (DataRow dr in dt.Rows)
                        {
                            var i = 0;
                            if (Int64.TryParse(dr[0].ToString().Trim(), out value))
                            {
                                DataRow[] row = dt.Select("Iqama ='" + dr[0] + "'");

                                excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, salaryAmntCol].Value = row[0]["Bank"];

                                if (row[0]["Bank"].ToString() != "0")
                                {
                                    excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, salaryAmntCol + 1].Value = row[0]["BasicSalary"];
                                    excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, salaryAmntCol + 2].Value = row[0]["HousingAllowance"];
                                    excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, salaryAmntCol + 3].Value = row[0]["OtherEarnings"];
                                    decimal deduction;

                                    try
                                    {
                                        deduction = (Convert.ToDecimal(row[0]["BasicSalary"]) + Convert.ToDecimal(row[0]["HousingAllowance"]) + Convert.ToDecimal(row[0]["OtherEarnings"])) - Convert.ToDecimal(row[0]["Bank"]);
                                    }
                                    catch (Exception)
                                    {
                                        deduction = 0m;
                                    }

                                    excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, salaryAmntCol + 4].Value = deduction;
                                    excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, salaryAmntCol + 5].Value = TextBoxPaymentDescription.Text;
                                    excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, salaryAmntCol + 6].Value = "Riyadh";
                                    excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, salaryAmntCol + 7].Value = "Riyadh";
                                    excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, salaryAmntCol + 8].Value = "Riyadh";
                                }
                            }
                        }
                        excelPackage.Save();
                    }
                }
                HideZeroBigRows(xPath);
                HideZeroBigRows2(xPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateSmallSalaries(DataTable dt, string xPath, int salaryAmntCol)
        {
            try
            {
                int tableNum = 0;
                int counter = 1;
                var filePathS = textBoxSmall.Text;
                var ctsS = new DataTableName().GetDataTableName(new WorkSheetName().GetWorkSheetName(filePathS), filePathS);

                foreach (var ct in ctsS)
                {
                    if (ct.ColoumnCount == 9)
                    {
                        tableNum = counter;
                        break;
                    }
                    counter++;
                }

                var fileinfo = new FileInfo(xPath);
                if (fileinfo.Exists)
                {
                    using (ExcelPackage excelPackage = new ExcelPackage(fileinfo))
                    {
                        Int64 value;
                        ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[tableNum]; //todo make dynamic
                        decimal tot = 0m;
                        int rowNum = 0;
                        foreach (DataRow dr in dt.Rows)
                        {
                            if (Int64.TryParse(dr[1].ToString().Trim(), out value))
                            {
                                DataRow[] row = dt.Select("BatchNo ='" + dr[1] + "'");
                                if (row[0]["Payroll"].ToString() != "0")
                                {
                                    excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, salaryAmntCol].Value = row[0]["Payroll"];
                                    excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, salaryAmntCol + 1].Value = TextBoxPaymentDescription.Text;
                                    tot += Convert.ToDecimal(row[0]["Payroll"]);
                                    rowNum = Convert.ToInt32(row[0]["RowNum"]);
                                }
                            }
                        }
                        excelWorksheet.Cells[rowNum + 4, salaryAmntCol].Value = tot;
                        excelPackage.Save();
                    }
                }
                HideZeroSmallRows(xPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void HideZeroBigRows(string xpath)
        {
            try
            {
                var fileinfo = new FileInfo(xpath);
                if (fileinfo.Exists)
                {
                    using (ExcelPackage excelPackage = new ExcelPackage(fileinfo))
                    {
                        ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[1];
                        excelWorksheet.Cells
                            .Where(cell =>
                                cell.Address.StartsWith("F")
                                && cell.Value is double
                                && (double)cell.Value == 00d)
                            .Select(cell => cell.Start.Row)
                            .ToList()
                            .ForEach(r => excelWorksheet.Row(r).Hidden = true);
                        excelPackage.Save();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }
        private void HideZeroBigRows2(string xpath)
        {
            try
            {
                var fileinfo = new FileInfo(xpath);
                if (fileinfo.Exists)
                {
                    using (ExcelPackage excelPackage = new ExcelPackage(fileinfo))
                    {
                        ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[1];
                        excelWorksheet.Cells
                            .Where(cell =>
                                cell.Address.StartsWith("E")
                                && cell.Value is double
                                && (double)cell.Value == 00d)
                            .Select(cell => cell.Start.Row)
                            .ToList()
                            .ForEach(r => excelWorksheet.Row(r).Hidden = true);
                        excelPackage.Save();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }
        private void HideZeroSmallRows(string xpath)
        {
            try
            {
                var fileinfo = new FileInfo(xpath);
                if (fileinfo.Exists)
                {
                    using (ExcelPackage excelPackage = new ExcelPackage(fileinfo))
                    {
                        ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[2];
                        excelWorksheet.Cells
                            .Where(cell =>
                                cell.Address.StartsWith("H")
                                && cell.Value is double
                                && (double)cell.Value == 00d) //todo make dynamic
                            .Select(cell => cell.Start.Row)
                            .ToList()
                            .ForEach(r => excelWorksheet.Row(r).Hidden = true);
                        excelPackage.Save();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }
        private void HideZeroPayrollProofRows(string xpath)
        {
            try
            {
                var fileinfo = new FileInfo(xpath);
                if (fileinfo.Exists)
                {
                    using (ExcelPackage excelPackage = new ExcelPackage(fileinfo))
                    {
                        ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[1];
                        excelWorksheet.Cells
                            .Where(cell =>
                                cell.Address.StartsWith("D")
                                && cell.Value is double
                                && (double)cell.Value == 00d)
                            .Select(cell => cell.Start.Row)
                            .ToList()
                            .ForEach(r => excelWorksheet.Row(r).Hidden = true);
                        excelPackage.Save();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }
        private void HideZeroSummary(string xpath)
        {
            try
            {
                var fileinfo = new FileInfo(xpath);
                if (fileinfo.Exists)
                {
                    using (ExcelPackage excelPackage = new ExcelPackage(fileinfo))
                    {
                        ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[1];
                        excelWorksheet.Cells
                            .Where(cell =>
                                cell.Address.StartsWith("G") //workaround to show cash
                                && cell.Value is double
                                && (double)cell.Value == 00d)
                            .Select(cell => cell.Start.Row)
                            .ToList()
                            .ForEach(r => excelWorksheet.Row(r).Hidden = true);
                        excelWorksheet.Cells["G1:G125"].Style.Numberformat.Format = "0";
                        excelPackage.Save();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }
        private void ShadeBorder(string xpath, int colNum, DataTable dtBigSalary, DataTable dtSmallSalary)
        {
            try
            {
                var path = Path.GetDirectoryName(xpath);
                File.Copy(Application.StartupPath + "\\Template\\PayrollProof.xlsx", path + "\\PayrollProof.xlsx", true);

                var fileinfo = new FileInfo(path + "\\PayrollProof.xlsx");
                if (fileinfo.Exists)
                {
                    int CashCount = 0;
                    using (ExcelPackage excelPackage = new ExcelPackage(fileinfo))
                    {
                        ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[1];
                        excelWorksheet.InsertRow(6, colNum);
                        var modelRows = 6 + colNum;
                        string modelRange = "A6:O" + modelRows;
                        var modelTable = excelWorksheet.Cells[modelRange];

                        modelTable.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        modelTable.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        modelTable.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                        modelTable.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;

                        var dtAll = dtBigSalary.AsEnumerable().Union(dtSmallSalary.AsEnumerable(),
                                    DataRowComparer.Default);

                        //Payroll Proof
                        int i = 4;
                        int ones = 0, fives = 0, tens = 0, fifties = 0, hundreds = 0, fivehundreds = 0;
                        decimal totalEarnings = 0m, deduc = 0m, netpay = 0m, creditCard = 0m, transfer = 0m, cash = 0m;
                        foreach (var dr in dtAll)
                        {
                            excelWorksheet.Cells[i, 1].Value = dr[0].ToString().Trim();
                            excelWorksheet.Cells[i, 2].Value = dr[10].ToString().Trim();
                            excelWorksheet.Cells[i, 3].Value = "STL";
                            excelWorksheet.Cells[i, 6].Value = Convert.ToDecimal(dr[4].ToString().Trim());
                            netpay += Convert.ToDecimal(dr[4].ToString().Trim());

                            if (dr[4].ToString().Trim() != "0")
                            {
                                excelWorksheet.Cells[i, 4].Value = Convert.ToDecimal(dr[6].ToString().Trim());
                                totalEarnings += Convert.ToDecimal(dr[6].ToString().Trim());

                                decimal deduction;
                                try
                                {
                                    deduction = (Convert.ToDecimal(dr[6].ToString().Trim()) +
                                                 Convert.ToDecimal(dr[7].ToString().Trim()) +
                                                 Convert.ToDecimal(dr[8].ToString().Trim())) -
                                                 Convert.ToDecimal(dr[4].ToString().Trim());
                                }
                                catch (Exception)
                                {
                                    deduction = 0m;
                                }

                                deduc += deduction;
                                excelWorksheet.Cells[i, 5].Value = Convert.ToDecimal(deduction);

                                excelWorksheet.Cells[i, 7].Value = Convert.ToDecimal(dr[11].ToString().Trim());
                                creditCard += Convert.ToDecimal(dr[11].ToString().Trim());
                                excelWorksheet.Cells[i, 8].Value = Convert.ToDecimal(dr[12].ToString().Trim());
                                transfer += Convert.ToDecimal(dr[12].ToString().Trim());

                                if (dr[5].ToString().Trim() != "0.00" && dr[5].ToString().Trim() != "0")
                                {
                                    CashCount++;
                                }

                                excelWorksheet.Cells[i, 9].Value = Convert.ToDecimal(dr[5].ToString().Trim());
                                cash += Convert.ToDecimal(dr[5].ToString().Trim());

                                var money = new SeparateMoney().Separate(Convert.ToDecimal(dr[5].ToString().Trim()));

                                excelWorksheet.Cells[i, 10].Value = money["1+"];
                                excelWorksheet.Cells[i, 11].Value = money["5+"];
                                excelWorksheet.Cells[i, 12].Value = money["10+"];
                                excelWorksheet.Cells[i, 13].Value = money["50+"];
                                excelWorksheet.Cells[i, 14].Value = money["100+"];
                                excelWorksheet.Cells[i, 15].Value = money["500+"];

                                ones += Convert.ToInt32(money["1+"]);
                                fives += Convert.ToInt32(money["5+"]);
                                tens += Convert.ToInt32(money["10+"]);
                                fifties += Convert.ToInt32(money["50+"]);
                                hundreds += Convert.ToInt32(money["100+"]);
                                fivehundreds += Convert.ToInt32(money["500+"]);
                            }
                            else
                            {
                                excelWorksheet.Cells[i, 4].Value = 0m;
                                excelWorksheet.Cells[i, 5].Value = 0m;
                                excelWorksheet.Cells[i, 6].Value = 0m;
                                excelWorksheet.Cells[i, 7].Value = 0m;
                                excelWorksheet.Cells[i, 8].Value = 0m;
                                excelWorksheet.Cells[i, 9].Value = 0m;

                                excelWorksheet.Cells[i, 10].Value = 0;
                                excelWorksheet.Cells[i, 11].Value = 0;
                                excelWorksheet.Cells[i, 12].Value = 0;
                                excelWorksheet.Cells[i, 13].Value = 0;
                                excelWorksheet.Cells[i, 14].Value = 0;
                                excelWorksheet.Cells[i, 15].Value = 0;
                            }
                            i++;
                        }

                        excelWorksheet.Cells[i, 4].Value = Convert.ToDecimal(totalEarnings);
                        excelWorksheet.Cells[i, 5].Value = Convert.ToDecimal(deduc);
                        excelWorksheet.Cells[i, 6].Value = Convert.ToDecimal(netpay);
                        excelWorksheet.Cells[i, 7].Value = Convert.ToDecimal(creditCard);
                        excelWorksheet.Cells[i, 8].Value = Convert.ToDecimal(transfer);
                        excelWorksheet.Cells[i, 9].Value = Convert.ToDecimal(cash);

                        excelWorksheet.Cells[i, 10].Value = ones;
                        excelWorksheet.Cells[i, 11].Value = fives;
                        excelWorksheet.Cells[i, 12].Value = tens;
                        excelWorksheet.Cells[i, 13].Value = fifties;
                        excelWorksheet.Cells[i, 14].Value = hundreds;
                        excelWorksheet.Cells[i, 15].Value = fivehundreds;

                        excelWorksheet.Cells["D:I"].Style.Numberformat.Format = "#,##0.00";

                        excelPackage.Save();
                    }
                    HideZeroPayrollProofRows(path + "\\PayrollProof.xlsx");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }
        private void Summary(string xpath, DataTable dtSummary, DataTable dtSmallSalary, DataTable dtBigSalary)
        {
            var path = Path.GetDirectoryName(xpath);
            File.Copy(Application.StartupPath + "\\Template\\Summary.xlsx", path + "\\Summary.xlsx", true);
            try
            {
                var fileinfo = new FileInfo(path + "\\Summary.xlsx");
                var query = dtSummary.AsEnumerable()
                    .GroupBy(r => new { Company = r.Field<string>("Company") })
                    .Select(grp => new
                    {
                        Company = grp.Key.Company,
                        Count = grp.Count(),
                        TotalCash = grp.Sum(c => c.Field<decimal>("Cash")),
                        Transfer = grp.Sum(c => c.Field<decimal>("Transfer")),
                        Credit = grp.Sum(c => c.Field<decimal>("Credit"))
                    });

                decimal cash = 0m;
                foreach (var item in query)
                {
                    if (item.Company != "")
                    {
                        cash += item.TotalCash;
                    }
                }

                //Small
                var qrySmall = dtSmallSalary.AsEnumerable()
                    .GroupBy(r => new { Company = r.Field<string>("Company") })
                    .Select(grp => new
                    {
                        Company = grp.Key.Company,
                        Count = grp.Count(),
                        TotalCash = grp.Sum(c => c.Field<decimal>("Cash")),
                        Transfer = grp.Sum(c => c.Field<decimal>("Transfer")),
                        Credit = grp.Sum(c => c.Field<decimal>("Credit")),
                        Bank = grp.Sum(c => c.Field<decimal>("Bank")),
                        Payroll = grp.Sum(c => c.Field<decimal>("Payroll"))
                    });
                decimal bankSmall = 0m;
                decimal payrollSmall = 0m;
                foreach (var item in qrySmall)
                {
                    if (item.Company != "")
                    {
                        bankSmall += item.Bank;
                        payrollSmall += item.Credit;
                    }
                }

                //Big
                var qryBig = dtBigSalary.AsEnumerable()
                    .GroupBy(r => new { Company = r.Field<string>("Company") })
                    .Select(grp => new
                    {
                        Company = grp.Key.Company,
                        Count = grp.Count(),
                        TotalCash = grp.Sum(c => c.Field<decimal>("Cash")),
                        Transfer = grp.Sum(c => c.Field<decimal>("Transfer")),
                        Credit = grp.Sum(c => c.Field<decimal>("Credit")),
                        Bank = grp.Sum(c => c.Field<decimal>("Bank")),
                        Payroll = grp.Sum(c => c.Field<decimal>("Payroll"))
                    });

                decimal bankBig = 0m;
                decimal payrollBig = 0m;
                foreach (var item in qryBig)
                {
                    if (item.Company != "")
                    {
                        bankBig += item.Bank;
                        payrollBig += item.Transfer;
                    }
                }

                #region EmpCount
                var queryCashCount = dtSummary.AsEnumerable()
                             .Where(r => r.Field<decimal>("Cash") != 0m);
                var queryPayrollCount = dtSmallSalary.AsEnumerable()
                             .ToList();
                var queryTransferCount = dtBigSalary.AsEnumerable()
                             .ToList();
                #endregion

                //Write to Excel
                try
                {
                    var path1 = Path.GetDirectoryName(textBoxSmall.Text);

                    var fileinfo1 = new FileInfo(path1 + "\\Summary.xlsx");
                    if (fileinfo1.Exists)
                    {
                        int CashCount = 0;
                        using (ExcelPackage excelPackage = new ExcelPackage(fileinfo))
                        {
                            ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[1];

                            //Cash
                            excelWorksheet.Cells[4, 2].Value = cash;
                            excelWorksheet.Cells[4, 3].Value = 0m;
                            excelWorksheet.Cells[4, 4].Value = cash - 0m;
                            excelWorksheet.Cells[4, 5].Value = queryCashCount.Count();

                            //Credit
                            excelWorksheet.Cells[5, 2].Value = payrollSmall;
                            //excelWorksheet.Cells[5, 3].Value = bankSmall;
                            excelWorksheet.Cells[5, 4].Value = payrollSmall - bankSmall;
                            excelWorksheet.Cells[5, 5].Value = queryPayrollCount.Count();

                            //Transfer
                            excelWorksheet.Cells[6, 2].Value = payrollBig;
                            //excelWorksheet.Cells[6, 3].Value = bankBig;
                            excelWorksheet.Cells[6, 4].Value = payrollBig - bankBig;
                            excelWorksheet.Cells[6, 5].Value = queryTransferCount.Count();

                            //Sum
                            excelWorksheet.Cells[7, 2].Value = cash + payrollSmall + payrollBig;
                            excelWorksheet.Cells[7, 3].Value = bankSmall + bankBig;
                            excelWorksheet.Cells[7, 4].Value = cash + (payrollSmall + payrollBig) - (bankSmall + bankBig);
                            excelWorksheet.Cells[7, 5].Value = queryCashCount.Count() + queryPayrollCount.Count() + queryTransferCount.Count();

                            var netpay1 = 0m;
                            var credit1 = 0m;
                            var transfer1 = 0m;
                            var cashi1 = 0m;
                            var counti1 = 0m;

                            //KTC
                            excelWorksheet.Cells[12, 3].Value = new NetPay().NetPayPerCompany(dtSummary, "KTC");
                            excelWorksheet.Cells[12, 4].Value = new Credit().CreditPerCompany(dtSummary, "KTC");
                            excelWorksheet.Cells[12, 5].Value = new Transfer().TransferPerCompany(dtSummary, "KTC");
                            excelWorksheet.Cells[12, 6].Value = new Cash().CashPerCompany(dtSummary, "KTC");
                            excelWorksheet.Cells[12, 7].Value = new CompanyCount().CountPerCompany(dtSummary, "KTC");

                            excelWorksheet.Cells[13, 3].Value = new NetPay().NetPayPerCompany(dtSummary, "KTC");
                            excelWorksheet.Cells[13, 4].Value = new Credit().CreditPerCompany(dtSummary, "KTC");
                            excelWorksheet.Cells[13, 5].Value = new Transfer().TransferPerCompany(dtSummary, "KTC");
                            excelWorksheet.Cells[13, 6].Value = new Cash().CashPerCompany(dtSummary, "KTC");
                            excelWorksheet.Cells[13, 7].Value = new CompanyCount().CountPerCompany(dtSummary, "KTC");

                            netpay1 += new NetPay().NetPayPerCompany(dtSummary, "KTC");
                            credit1 += new Credit().CreditPerCompany(dtSummary, "KTC");
                            transfer1 += new Transfer().TransferPerCompany(dtSummary, "KTC");
                            cashi1 += new Cash().CashPerCompany(dtSummary, "KTC");
                            counti1 += new CompanyCount().CountPerCompany(dtSummary, "KTC");

                            //RFPB
                            excelWorksheet.Cells[14, 3].Value = new NetPay().NetPayPerCompany(dtSummary, "RFPB");
                            excelWorksheet.Cells[14, 4].Value = new Credit().CreditPerCompany(dtSummary, "RFPB");
                            excelWorksheet.Cells[14, 5].Value = new Transfer().TransferPerCompany(dtSummary, "RFPB");
                            excelWorksheet.Cells[14, 6].Value = new Cash().CashPerCompany(dtSummary, "RFPB");
                            excelWorksheet.Cells[14, 7].Value = new CompanyCount().CountPerCompany(dtSummary, "RFPB");

                            excelWorksheet.Cells[15, 3].Value = new NetPay().NetPayPerCompany(dtSummary, "RFPB");
                            excelWorksheet.Cells[15, 4].Value = new Credit().CreditPerCompany(dtSummary, "RFPB");
                            excelWorksheet.Cells[15, 5].Value = new Transfer().TransferPerCompany(dtSummary, "RFPB");
                            excelWorksheet.Cells[15, 6].Value = new Cash().CashPerCompany(dtSummary, "RFPB");
                            excelWorksheet.Cells[15, 7].Value = new CompanyCount().CountPerCompany(dtSummary, "RFPB");

                            netpay1 += new NetPay().NetPayPerCompany(dtSummary, "RFPB");
                            credit1 += new Credit().CreditPerCompany(dtSummary, "RFPB");
                            transfer1 += new Transfer().TransferPerCompany(dtSummary, "RFPB");
                            cashi1 += new Cash().CashPerCompany(dtSummary, "RFPB");
                            counti1 += new CompanyCount().CountPerCompany(dtSummary, "RFPB");

                            //SIP
                            excelWorksheet.Cells[16, 3].Value = new NetPay().NetPayPerCompany(dtSummary, "SIP");
                            excelWorksheet.Cells[16, 4].Value = new Credit().CreditPerCompany(dtSummary, "SIP");
                            excelWorksheet.Cells[16, 5].Value = new Transfer().TransferPerCompany(dtSummary, "SIP");
                            excelWorksheet.Cells[16, 6].Value = new Cash().CashPerCompany(dtSummary, "SIP");
                            excelWorksheet.Cells[16, 7].Value = new CompanyCount().CountPerCompany(dtSummary, "SIP");

                            excelWorksheet.Cells[17, 3].Value = new NetPay().NetPayPerCompany(dtSummary, "SIP");
                            excelWorksheet.Cells[17, 4].Value = new Credit().CreditPerCompany(dtSummary, "SIP");
                            excelWorksheet.Cells[17, 5].Value = new Transfer().TransferPerCompany(dtSummary, "SIP");
                            excelWorksheet.Cells[17, 6].Value = new Cash().CashPerCompany(dtSummary, "SIP");
                            excelWorksheet.Cells[17, 7].Value = new CompanyCount().CountPerCompany(dtSummary, "SIP");

                            netpay1 += new NetPay().NetPayPerCompany(dtSummary, "SIP");
                            credit1 += new Credit().CreditPerCompany(dtSummary, "SIP");
                            transfer1 += new Transfer().TransferPerCompany(dtSummary, "SIP");
                            cashi1 += new Cash().CashPerCompany(dtSummary, "SIP");
                            counti1 += new CompanyCount().CountPerCompany(dtSummary, "SIP");

                            //TDF
                            excelWorksheet.Cells[18, 3].Value = new NetPay().NetPayPerCompany(dtSummary, "TDF");
                            excelWorksheet.Cells[18, 4].Value = new Credit().CreditPerCompany(dtSummary, "TDF");
                            excelWorksheet.Cells[18, 5].Value = new Transfer().TransferPerCompany(dtSummary, "TDF");
                            excelWorksheet.Cells[18, 6].Value = new Cash().CashPerCompany(dtSummary, "TDF");
                            excelWorksheet.Cells[18, 7].Value = new CompanyCount().CountPerCompany(dtSummary, "TDF");

                            excelWorksheet.Cells[19, 3].Value = new NetPay().NetPayPerCompany(dtSummary, "TDF");
                            excelWorksheet.Cells[19, 4].Value = new Credit().CreditPerCompany(dtSummary, "TDF");
                            excelWorksheet.Cells[19, 5].Value = new Transfer().TransferPerCompany(dtSummary, "TDF");
                            excelWorksheet.Cells[19, 6].Value = new Cash().CashPerCompany(dtSummary, "TDF");
                            excelWorksheet.Cells[19, 7].Value = new CompanyCount().CountPerCompany(dtSummary, "TDF");

                            netpay1 += new NetPay().NetPayPerCompany(dtSummary, "TDF");
                            credit1 += new Credit().CreditPerCompany(dtSummary, "TDF");
                            transfer1 += new Transfer().TransferPerCompany(dtSummary, "TDF");
                            cashi1 += new Cash().CashPerCompany(dtSummary, "TDF");
                            counti1 += new CompanyCount().CountPerCompany(dtSummary, "TDF");

                            //TMF
                            excelWorksheet.Cells[20, 3].Value = new NetPay().NetPayPerCompany(dtSummary, "TMF");
                            excelWorksheet.Cells[20, 4].Value = new Credit().CreditPerCompany(dtSummary, "TMF");
                            excelWorksheet.Cells[20, 5].Value = new Transfer().TransferPerCompany(dtSummary, "TMF");
                            excelWorksheet.Cells[20, 6].Value = new Cash().CashPerCompany(dtSummary, "TMF");
                            excelWorksheet.Cells[20, 7].Value = new CompanyCount().CountPerCompany(dtSummary, "TMF");

                            excelWorksheet.Cells[21, 3].Value = new NetPay().NetPayPerCompany(dtSummary, "TMF");
                            excelWorksheet.Cells[21, 4].Value = new Credit().CreditPerCompany(dtSummary, "TMF");
                            excelWorksheet.Cells[21, 5].Value = new Transfer().TransferPerCompany(dtSummary, "TMF");
                            excelWorksheet.Cells[21, 6].Value = new Cash().CashPerCompany(dtSummary, "TMF");
                            excelWorksheet.Cells[21, 7].Value = new CompanyCount().CountPerCompany(dtSummary, "TMF");

                            netpay1 += new NetPay().NetPayPerCompany(dtSummary, "TMF");
                            credit1 += new Credit().CreditPerCompany(dtSummary, "TMF");
                            transfer1 += new Transfer().TransferPerCompany(dtSummary, "TMF");
                            cashi1 += new Cash().CashPerCompany(dtSummary, "TMF");
                            counti1 += new CompanyCount().CountPerCompany(dtSummary, "TMF");

                            //STL
                            using (var _context = new STLxEntities())
                            {
                                var companyList = _context.Companies
                                    .SqlQuery("SELECT * FROM [Company] WHERE Id  NOT IN(47, 44, 41, 35, 8) AND Status = 1  AND IsDelete = 0 ORDER BY Name")
                                    .ToList();

                                int rowNum = 22;
                                foreach (var clist in companyList)
                                {
                                    Console.WriteLine(clist);
                                    excelWorksheet.Cells[rowNum, 2].Value = clist.Name;
                                    rowNum++;
                                }

                                int initialRow = 22;
                                var netpay2 = 0m;
                                var credit2 = 0m;
                                var transfer2 = 0m;
                                var cashi2 = 0m;
                                var counti2 = 0m;

                                foreach (var clist in companyList)
                                {
                                    excelWorksheet.Cells[initialRow, 3].Value = new NetPay().NetPayPerCompany(dtSummary, clist.Code);
                                    excelWorksheet.Cells[initialRow, 4].Value = new Credit().CreditPerCompany(dtSummary, clist.Code);
                                    excelWorksheet.Cells[initialRow, 5].Value = new Transfer().TransferPerCompany(dtSummary, clist.Code);
                                    excelWorksheet.Cells[initialRow, 6].Value = new Cash().CashPerCompany(dtSummary, clist.Code);
                                    excelWorksheet.Cells[initialRow, 7].Value = new CompanyCount().CountPerCompany(dtSummary, clist.Code);

                                    netpay2 += new NetPay().NetPayPerCompany(dtSummary, clist.Code);
                                    credit2 += new Credit().CreditPerCompany(dtSummary, clist.Code);
                                    transfer2 += new Transfer().TransferPerCompany(dtSummary, clist.Code);
                                    cashi2 += new Cash().CashPerCompany(dtSummary, clist.Code);
                                    counti2 += new CompanyCount().CountPerCompany(dtSummary, clist.Code);

                                    initialRow++;
                                }
                                excelWorksheet.Cells[initialRow, 3].Value = netpay2;
                                excelWorksheet.Cells[initialRow, 4].Value = credit2;
                                excelWorksheet.Cells[initialRow, 5].Value = transfer2;
                                excelWorksheet.Cells[initialRow, 6].Value = cashi2;
                                excelWorksheet.Cells[initialRow, 7].Value = counti2;

                                excelWorksheet.Cells[initialRow + 1, 3].Value = netpay1 + netpay2;
                                excelWorksheet.Cells[initialRow + 1, 4].Value = credit1 + credit2;
                                excelWorksheet.Cells[initialRow + 1, 5].Value = transfer1 + transfer2;
                                excelWorksheet.Cells[initialRow + 1, 6].Value = cashi1 + cashi2;
                                excelWorksheet.Cells[initialRow + 1, 7].Value = counti1 + counti2;

                                excelWorksheet.Cells[5, 3].Value = credit1 + credit2;
                                excelWorksheet.Cells[6, 3].Value = transfer1 + transfer2;
                            }
                            excelPackage.Save();
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    //throw;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            HideZeroSummary(path + "\\Summary.xlsx");
        }
    }
}
