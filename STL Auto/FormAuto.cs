﻿using OfficeOpenXml;
using OfficeOpenXml.Style;
using STL_Auto.Helpers;
using STL_Auto.Models;
using STL_Auto.Services;
using STL_Auto.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace STL_Auto
{
    public partial class FormAuto : Form
    {
        public FormAuto()
        {
            InitializeComponent();
            //Application.CurrentCulture = new CultureInfo("ar-SA");
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("ar-SA");
        }

        private void buttonPayroll_Click(object sender, EventArgs e)
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

        private void buttonGosi_Click(object sender, EventArgs e)
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

        private void buttonBig_Click(object sender, EventArgs e)
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

        private void buttonSmall_Click(object sender, EventArgs e)
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

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            var dtBigSalaries = new MakeTable().BigSalaries();
            var dtSmallSalaries = new MakeTable().BigSalaries();
            var dtAllSalaries = new MakeTable().BigSalaries();
            var dtPayrollProff = new PayrollProof().Payroll();
            var dsBigSalaries = new DataSet().Tables.Add(dtBigSalaries.TableName);
           
            DataTable dtPayroll = null;
            DataTable dtGosi = null;
            DataTable dtBig = null;
            DataTable dtSmall = null;

            #region BigSalaries
            var filePath = textBoxBig.Text;
            var ctsB = GetDataTableData(GetWorkSheetName(filePath), filePath);

            foreach (var ct in ctsB)
            {
                if (ct.ColoumnCount >= 13)
                {
                    dtBig = ct.Table;
                    break;
                }
            }
            
            foreach (DataRow dr in dtBig.Rows)
            {
                for (int i = 0; i < dtBig.Columns.Count; i++)
                {
                    if (new EmployeeIdNo().CheckMatch(dr[i].ToString().Trim()))
                    {
                        dtBigSalaries.Rows.Add(dr[i].ToString().Trim(), dr[i-1].ToString().Trim(), 0m, 0m, 0m, 0m, 0m, 0m, 0m, dtBig.Rows.IndexOf(dr).ToString(), dr[i+1].ToString().Trim());
                        break;
                    }
                }
            }
            #endregion

            #region SmallSalaries
            var filePathS = textBoxSmall.Text;
            var ctsS = GetDataTableData(GetWorkSheetName(filePathS), filePathS);

            foreach (var ct in ctsS)
            {
                if (ct.ColoumnCount == 9)
                {
                    dtSmall = ct.Table;
                    break;
                }
            }

            dataGridView3.DataSource = dtSmall;
            
            foreach (DataRow dr in dtSmall.Rows)
            {
                for (int i = 0; i < dtSmall.Columns.Count; i++)
                {
                    if (new EmployeeIdNo().CheckMatch(dr[i].ToString().Trim()))
                    {
                        dtSmallSalaries.Rows.Add(dr[i].ToString().Trim(), dr[i-3].ToString().Trim(), 0m, 0m, 0m, 0m, 0m, 0m, 0m, dtSmall.Rows.IndexOf(dr).ToString(), dr[i-1].ToString().Trim());
                        //dtSmallSalaries.Rows.Add(dr[i].ToString().Trim(), dr[i-5].ToString().Trim(), 0m, 0m, 0m, 0m, 0m, 0m, 0m, dtSmall.Rows.IndexOf(dr).ToString());
                        break;
                    }
                }
            }
            #endregion

            #region Gosi
            filePath = textBoxGosi.Text;
            var ctsG = GetDataTableData(GetWorkSheetName(filePath), filePath);

            foreach (var ct in ctsG)
            {
                if (ct.ColoumnCount == 14)
                {
                    dtGosi = ct.Table;
                    break;
                }
            }

            dataGridView2.DataSource = dtGosi;

            var empIdIndexGosi = GetGosiEmpIdColumn(dtGosi);
            var batchNoIndexGosi = GetGosiBatchNoColumn();
            var aestheticIndexGosi = GetGosiAestheticColumn();
            var basicSalaryIndexGosi = GetGosiBasicSalaryColumn();
            var housingAllowanceIndexGosi = GetHousingAllowanceColumn();
            var otherEarningsIndexGosi = GetOtherEarningsColumn();

            var EmpIdIndexBigSalaries = 0;
            Int64 emplIdValueGosi;

            //BIG
            foreach (DataRow dr in dtGosi.Rows)
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

                        row["Aesthetic"] = Convert.ToDecimal(dr[aestheticIndexGosi] == DBNull.Value ? 0 : dr[aestheticIndexGosi]);
                        row["BasicSalary"] = Convert.ToDecimal(dr[basicSalaryIndexGosi] == DBNull.Value ? 0 : dr[basicSalaryIndexGosi]);
                        row["HousingAllowance"] = Convert.ToDecimal(dr[housingAllowanceIndexGosi] ==  DBNull.Value ? 0 : dr[housingAllowanceIndexGosi]);
                        row["OtherEarnings"] = Convert.ToDecimal(dr[otherEarningsIndexGosi] == DBNull.Value ? 0 : dr[otherEarningsIndexGosi]);

                        //Console.WriteLine($"{row["BatchNo"]}, {row["Aesthetic"]}, {row["BasicSalary"]}, {row["HousingAllowance"]}, {row["OtherEarnings"]}");

                        dtBigSalaries.AcceptChanges();
                    }
                }
            }

            //SMALL
            foreach (DataRow dr in dtGosi.Rows)
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

                        row["Aesthetic"] = Convert.ToDecimal(dr[aestheticIndexGosi] == DBNull.Value ? 0 : dr[aestheticIndexGosi]);
                        row["BasicSalary"] = Convert.ToDecimal(dr[basicSalaryIndexGosi] == DBNull.Value ? 0 : dr[basicSalaryIndexGosi]);
                        row["HousingAllowance"] = Convert.ToDecimal(dr[housingAllowanceIndexGosi] ==  DBNull.Value ? 0 : dr[housingAllowanceIndexGosi]);
                        row["OtherEarnings"] = Convert.ToDecimal(dr[otherEarningsIndexGosi] == DBNull.Value ? 0 : dr[otherEarningsIndexGosi]);
                        //Console.WriteLine($"{row["BatchNo"]}, {row["Aesthetic"]}, {row["BasicSalary"]}, {row["HousingAllowance"]}, {row["OtherEarnings"]}");

                        dtSmallSalaries.AcceptChanges();
                    }
                }
            }

            #endregion

            #region PayrollBigSalary
            filePath = textBoxPayroll.Text;
            var ctsPB = GetDataTableData(GetWorkSheetName(filePath), filePath);

            foreach (var ct in ctsPB)
            {
                if (ct.ColoumnCount == 22)
                {
                    dtPayroll = ct.Table;
                    break;
                }
            }

            var netPayPayrollPB = GetPayrollNetPay(dtPayroll);
            var batchIDPayrollPB = GetPayrollBatchIdColumn(dtPayroll);
            
            Int64 batchIdPB;
            var payrollPB = new Dictionary<string, string>();
            foreach (DataRow dr in dtPayroll.Rows)
            {
                if (Int64.TryParse(dr[batchIDPayrollPB].ToString().Replace(".00", "").Replace(",","").Trim(), out batchIdPB))
                {
                    DataRow row = dtBigSalaries.Select("BatchNo ='" + batchIdPB + "'").FirstOrDefault();
                    if (row != null)
                    {
                        //Check Duplicate here remove then add again
                            if (!payrollPB.ContainsKey(row["Iqama"].ToString()))
                            {
                                payrollPB.Add(row["Iqama"].ToString(), dr[netPayPayrollPB].ToString());
                                //Console.WriteLine($"{dr[21]}");
                                //DataRow[] row = dtBigSalaries.Select("Iqama ='" + id.Key + "'");
                                row["Payroll"] = Convert.ToDecimal(dr[netPayPayrollPB]);
                                row["Bank"] = Convert.ToDecimal(dr[netPayPayrollPB]) >= Convert.ToDecimal(row["Aesthetic"]) ? Convert.ToDecimal(row["Aesthetic"]) : Convert.ToDecimal(dr[netPayPayrollPB]);
                                row["Cash"] = (Convert.ToDecimal(row["Payroll"]) - Convert.ToDecimal(row["Aesthetic"])) < 0 ? 0 : (Convert.ToDecimal(row["Payroll"]) - Convert.ToDecimal(row["Aesthetic"]));
                                //Console.WriteLine($"{batchId}, {row["Iqama"]}, {Convert.ToDecimal(dr[netPayPayroll])}, {Convert.ToDecimal(row["Aesthetic"])}");
                            }
                            else
                            {
                                //TODO not working part: duplicate
                                var firstSalary = payrollPB.SingleOrDefault(x => x.Key == row["Iqama"].ToString());
                                var salary = Convert.ToDecimal(dr[netPayPayrollPB]) + Convert.ToDecimal(firstSalary.Value);
                                payrollPB.Remove(firstSalary.Key);
                                payrollPB.Add(firstSalary.Key, salary.ToString());

                                Console.WriteLine($"Duplicate {firstSalary.Key} {salary}");

                                row["Payroll"] = salary;
                                row["Bank"] = Convert.ToDecimal(salary) >= Convert.ToDecimal(row["Aesthetic"]) ? Convert.ToDecimal(row["Aesthetic"]) : Convert.ToDecimal(dr[netPayPayrollPB]);
                                row["Cash"] = (Convert.ToDecimal(row["Payroll"]) - Convert.ToDecimal(row["Aesthetic"])) < 0 ? 0 : (Convert.ToDecimal(row["Payroll"]) - Convert.ToDecimal(row["Aesthetic"]));
                            }
                        dtBigSalaries.AcceptChanges();
                    }
                }
            }
            #endregion

            dataGridView1.DataSource = dtBigSalaries;
            var salaryAmountBig = GetBSalariesSalaryAmntColumn(dtBig);

            UpdateBigSalaries(dtBigSalaries, textBoxBig.Text, salaryAmountBig + 1);

            #region PayrollSmallSalary
            filePath = textBoxPayroll.Text;
            var ctsPS = GetDataTableData(GetWorkSheetName(filePath), filePath);

            foreach (var ct in ctsPS)
            {
                if (ct.ColoumnCount == 22)
                {
                    dtPayroll = ct.Table;
                    break;
                }
            }

            var netPayPayrollSB = GetPayrollNetPay(dtPayroll);
            var batchIDPayrollSB = GetPayrollBatchIdColumn(dtPayroll);
            
            Int64 batchIdSB;
            var payroll = new Dictionary<string, string>();
            foreach (DataRow dr in dtPayroll.Rows)
            {
                if (Int64.TryParse(dr[batchIDPayrollSB].ToString().Replace(".00", "").Replace(",","").Trim(), out batchIdSB))
                {
                    DataRow row = dtSmallSalaries.Select("BatchNo ='" + batchIdSB + "'").FirstOrDefault();

                    if (row != null)
                    {
                            if (!payroll.ContainsKey(row["Iqama"].ToString()))
                            {
                                payroll.Add(row["Iqama"].ToString(), dr[netPayPayrollSB].ToString());
                                row["Payroll"] = Convert.ToDecimal(dr[netPayPayrollSB]);
                                row["Bank"] = Convert.ToDecimal(dr[netPayPayrollPB]) >= Convert.ToDecimal(row["Aesthetic"]) ? Convert.ToDecimal(row["Aesthetic"]) : Convert.ToDecimal(dr[netPayPayrollPB]);
                                row["Cash"] = (Convert.ToDecimal(row["Payroll"]) - Convert.ToDecimal(row["Aesthetic"])) < 0 ? 0 : (Convert.ToDecimal(row["Payroll"]) - Convert.ToDecimal(row["Aesthetic"]));
                        }
                            else
                            {
                                //TODO not working part: duplicate
                                var firstSalary = payroll.SingleOrDefault(x => x.Key == row["Iqama"].ToString());
                                var salary = Convert.ToDecimal(dr[netPayPayrollSB]) + Convert.ToDecimal(firstSalary.Value);
                                payroll.Remove(firstSalary.Key);
                                payroll.Add(firstSalary.Key, salary.ToString());
                                Console.WriteLine($"Duplicate {firstSalary.Key} {salary}");
                                row["Payroll"] = salary;
                                row["Bank"] = Convert.ToDecimal(salary) >= Convert.ToDecimal(row["Aesthetic"]) ? Convert.ToDecimal(row["Aesthetic"]) : Convert.ToDecimal(dr[netPayPayrollPB]);
                                row["Cash"] = (Convert.ToDecimal(row["Payroll"]) - Convert.ToDecimal(row["Aesthetic"])) < 0 ? 0 : (Convert.ToDecimal(row["Payroll"]) - Convert.ToDecimal(row["Aesthetic"]));
                        }
                        dtSmallSalaries.AcceptChanges();
                    }
                }
            }
            #endregion

            dataGridView1.DataSource = dtSmallSalaries;

            var salaryAmountSmall = GetSSalariesSalaryAmntColumn();

            UpdateSmallSalaries(dtSmallSalaries, textBoxSmall.Text, salaryAmountSmall + 1);

            ShadeBorder(textBoxSmall.Text, dtBigSalaries.Rows.Count + dtSmallSalaries.Rows.Count-3, dtBigSalaries, dtSmallSalaries);
            
        }

        private int GetGosiEmpIdColumn(DataTable dTable)
        {
            int columnNum = 0;
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
            return columnNum;
        }

        private int GetGosiAestheticColumn()
        {
            int columnNum = 0;
            
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                if (column.HeaderText == "الجمالي بعد البدلات")
                {
                    columnNum = column.Index;
                    break;
                }
            }

            return columnNum;
        }

        private int GetGosiBatchNoColumn()
        {
            int columnNum = 0;
            
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                if (column.HeaderText == "الرقم الوظيفي بالمنشأة")
                {
                    columnNum = column.Index;
                    break;
                }
            }

            return columnNum;
        }

        private int GetGosiBasicSalaryColumn()
        {
            int columnNum = 0;
            
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                if (column.HeaderText == "الأجر الأساسي")
                {
                    columnNum = column.Index;
                    break;
                }
            }

            return columnNum;
        }

        private int GetHousingAllowanceColumn()
        {
            int columnNum = 0;
            
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                if (column.HeaderText == "بدل السكن الشهري")
                {
                    columnNum = column.Index;
                    break;
                }
            }

            return columnNum;
        }

        private int GetOtherEarningsColumn()
        {
            int columnNum = 0;
            
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                if (column.HeaderText == "بدلات أخرى")
                {
                    columnNum = column.Index;
                    break;
                }
            }

            return columnNum;
        }

        private int GetPayrollNetPay(DataTable dTable)
        {
            int columnNum = 0;
            foreach (DataRow dr in dTable.Rows)
            {
                for (int i = 0; i < dTable.Columns.Count; i++)
                {
                    if (dr[i].ToString().Trim() == "Net Pay")
                    {
                        columnNum = i;
                        break;
                    }
                }
            }
            return columnNum;
        }

        private int GetPayrollBatchIdColumn(DataTable dTable)
        {
            int columnNum = 0;
            foreach (DataRow dr in dTable.Rows)
            {
                for (int i = 0; i < dTable.Columns.Count; i++)
                {
                    if (dr[i].ToString().Trim() == "Emp. ID")
                    {
                        columnNum = i;
                        break;
                    }
                }
            }
            return columnNum;
        }

        private int GetBSalariesSalaryAmntColumn(DataTable dTable)
        {
            int columnNum = 0;
            foreach (DataRow dr in dTable.Rows)
            {
                for (int i = 0; i < dTable.Columns.Count; i++)
                {
                    if (dr[i].ToString().Trim() == "Salary Amount")
                    {
                        columnNum = i;
                        break;
                    }
                }
            }
            return columnNum;
        }

        private int GetSSalariesIDNumberColumn(DataTable dTable)
        {
            int columnNum = 0;
            foreach (DataRow dr in dTable.Rows)
            {
                for (int i = 0; i < dTable.Columns.Count; i++)
                {
                    if (dr[i].ToString().Trim() == "ID Number")
                    {
                        columnNum = i;
                        break;
                    }
                }
            }
            return columnNum;
        }

        private int GetSSalariesSalaryAmntColumn()
        {
            int columnNum = 0; 

            foreach (DataGridViewColumn column in dataGridView3.Columns)
            {
                if (column.HeaderText == "Salary_Amount")
                {
                    columnNum = column.Index;
                    break;
                }
            }

            return columnNum;
        }

        private void UpdateBigSalaries(DataTable dt, string xPath, int salaryAmntCol)
        {
            try
            {
                var fileinfo = new FileInfo(xPath);
                if (fileinfo.Exists)
                {
                    using (ExcelPackage excelPackage = new ExcelPackage(fileinfo))
                    {
                        Int64 value;
                        ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[1];
                        foreach (DataRow dr in dt.Rows)
                        {
                            var i = 0;
                            if (Int64.TryParse(dr[0].ToString().Trim(), out value))
                            {
                                DataRow[] row = dt.Select("Iqama ='" + dr[0] + "'");

                                excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, salaryAmntCol].Value = row[0]["Bank"];
                                excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, salaryAmntCol+1].Value = row[0]["BasicSalary"];
                                excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, salaryAmntCol+2].Value = row[0]["HousingAllowance"];
                                excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, salaryAmntCol+3].Value = row[0]["OtherEarnings"];
                                decimal deduction;
                                try
                                {
                                    deduction = (Convert.ToDecimal(row[0]["BasicSalary"]) + Convert.ToDecimal(row[0]["HousingAllowance"]) + Convert.ToDecimal(row[0]["OtherEarnings"])) - Convert.ToDecimal(row[0]["Bank"]);
                                }
                                catch (Exception e)
                                {
                                    deduction = 0m;
                                }
                                excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, salaryAmntCol+4].Value = deduction;
                                excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, salaryAmntCol+5].Value = TextBoxPaymentDescription.Text;
                                excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, salaryAmntCol+6].Value = "Riyadh";
                                excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, salaryAmntCol+7].Value = "Riyadh";
                                excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, salaryAmntCol+8].Value = "Riyadh";
                            }
                        }
                        excelPackage.Save();
                    }
                }

                DeleteZeroBigRows(xPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void UpdateSmallSalaries(DataTable dt, string xPath, int salaryAmntCol)
        {
            try
            {
                var fileinfo = new FileInfo(xPath);
                if (fileinfo.Exists)
                {
                    using (ExcelPackage excelPackage = new ExcelPackage(fileinfo))
                    {
                        Int64 value;
                        ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[2];
                        decimal tot = 0m;
                        int rowNum =0;
                        foreach (DataRow dr in dt.Rows)
                        {
                            if (Int64.TryParse(dr[1].ToString().Trim(), out value))
                            {
                                DataRow[] row = dt.Select("BatchNo ='" + dr[1] + "'");
                                excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, salaryAmntCol].Value = row[0]["Payroll"];
                                excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, salaryAmntCol +1].Value = TextBoxPaymentDescription.Text;
                                tot += Convert.ToDecimal(row[0]["Payroll"]);
                                rowNum = Convert.ToInt32(row[0]["RowNum"]);
                            }
                        }
                        excelWorksheet.Cells[rowNum + 4, salaryAmntCol].Value = tot;

                        excelPackage.Save();
                    }
                }

                DeleteZeroSmallRows(xPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private List<CustomTable> GetDataTableData(List<string> workSheetName, string filePath)
        {
            var ct = new List<CustomTable>(); 
            try
            {
                for (int i = 0; i < workSheetName.Count - 1; i++)
                {
                    var dtConnString =
                        new ConnectionString()
                        .GetConnectionString(Path.GetExtension(filePath), filePath); 
                                           
                    ct.Add(new CustomTable()
                    {
                        Table = new ExcelDataTable().GetDataTable(dtConnString, "[" + workSheetName[i] + "$]"), 
                        ColoumnCount = new ExcelDataTable().GetDataTable(dtConnString, "[" + workSheetName[i] + "$]").Columns.Count
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            return ct;
        }

        private List<string> GetWorkSheetName(string path)
        {
            var wsName = new List<string>();
            try
            {
                var fileinfo = new FileInfo(path);
                if (fileinfo.Exists)
                {
                    using (var package = new ExcelPackage(fileinfo))
                    {
                        package.Workbook.Worksheets.Add("Halla"); //WorkAround for list...
                        var ws = package.Workbook.Worksheets.Select(x => x.Name);
                        foreach (var sheet in ws)
                        {
                            //Console.WriteLine(sheet);
                            wsName.Add(sheet); 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            return wsName;
        }

        private void DeleteZeroBigRows(string xpath)
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

        private void DeleteZeroSmallRows(string xpath)
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
                            && (double)cell.Value == 00d)
                        .Select(cell => cell.Start.Row)
                        .ToList()
                        .ForEach(r => excelWorksheet.Row(r).Hidden = true);
                    excelPackage.Save();
                }
            }
        }

        private void ShadeBorder(string xpath, int colNum, DataTable dtBigSalaries, DataTable dtSmallSalaries)
        {
            var fileinfo = new FileInfo(Application.StartupPath + "\\Template\\PayrollProof.xlsx");
            if (fileinfo.Exists)
            {
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

                    var dtAll = dtBigSalaries.AsEnumerable().Union(dtSmallSalaries.AsEnumerable(),
                        DataRowComparer.Default);

                    //TODO Payroll Proof
                    int i = 4;
                    int ones=0, fives=0, tens=0, fifties=0, hundreds=0, fivehundreds = 0;
                    foreach (var dr in dtAll)
                    {
                        excelWorksheet.Cells[i, 1].Value = dr[0].ToString().Trim();
                        excelWorksheet.Cells[i, 2].Value = dr[10].ToString().Trim();
                        excelWorksheet.Cells[i, 3].Value = "STL";
                        excelWorksheet.Cells[i, 4].Value = dr[4].ToString().Trim();
                        decimal deduction;

                        try
                        {
                            deduction = (Convert.ToDecimal(dr[6].ToString().Trim()) + Convert.ToDecimal(dr[7].ToString().Trim()) + Convert.ToDecimal(dr[8].ToString().Trim())) - Convert.ToDecimal(dr[4].ToString().Trim());
                        }
                        catch (Exception e)
                        {
                            deduction = 0m;
                        }

                        excelWorksheet.Cells[i, 5].Value = deduction;
                        excelWorksheet.Cells[i, 6].Value = dr[3].ToString().Trim();
                        excelWorksheet.Cells[i, 7].Value = dr[4].ToString().Trim();
                        excelWorksheet.Cells[i, 8].Value = "0.00";
                        excelWorksheet.Cells[i, 9].Value = dr[5].ToString().Trim();

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

                        i++;
                    }

                    excelWorksheet.Cells[i, 10].Value = ones;
                    excelWorksheet.Cells[i, 11].Value = fives;
                    excelWorksheet.Cells[i, 12].Value = tens;
                    excelWorksheet.Cells[i, 13].Value = fifties;
                    excelWorksheet.Cells[i, 14].Value = hundreds;
                    excelWorksheet.Cells[i, 15].Value = fivehundreds;

                    excelPackage.Save();
                }
                var path = Path.GetDirectoryName(xpath);
                File.Copy(Application.StartupPath + "\\Template\\PayrollProof.xlsx", path + "\\PayrollProof.xlsx", true);
            }
        }
    }
}
